using GameVault.Data;
using GameVault.Models;

namespace GameVault.Services;

public class GameVaultState
{
    private readonly LocalStorageService _storage;
    private readonly ToastService _toast;

    public event Action? OnChange;

    public bool IsLoaded { get; private set; }
    private readonly List<Game> _catalog;
    private List<LibraryEntry> _library;
    private HashSet<string> _wishlist;
    private UserProfile _profile;
    private AppPreferences _preferences;
    private List<ActivityEntry> _activities;

    public GameVaultState(LocalStorageService storage, ToastService toast)
    {
        _storage = storage;
        _toast = toast;

        // Initialize synchronously with mock data
        _catalog = MockGameCatalog.GetGames();
        _library = MockGameCatalog.GetInitialLibrary();
        _wishlist = new HashSet<string>(MockGameCatalog.GetInitialWishlist());
        _profile = new UserProfile();
        _preferences = new AppPreferences();
        _activities = MockGameCatalog.GetInitialActivities();
    }

    public async Task InitializeAsync()
    {
        if (IsLoaded) return;

        var saved = await _storage.LoadStateAsync();
        if (saved != null)
        {
            if (saved.Library != null && saved.Library.Count > 0)
            {
                _library = saved.Library;
            }
            if (saved.Wishlist != null)
            {
                _wishlist = new HashSet<string>(saved.Wishlist);
            }
            if (saved.Profile != null)
            {
                _profile = saved.Profile;
            }
            if (saved.Preferences != null)
            {
                _preferences = saved.Preferences;
            }
            if (saved.Activities != null && saved.Activities.Count > 0)
            {
                _activities = saved.Activities;
            }
        }

        await _storage.ApplyDomPreferencesAsync(_preferences);
        IsLoaded = true;
        NotifyStateChanged();
    }

    public UserProfile Profile => _profile;
    public AppPreferences Preferences => _preferences;

    // --- Catalog Queries ---
    public IReadOnlyList<Game> GetAllGames() => _catalog.AsReadOnly();

    public Game? GetGameById(string? id)
    {
        if (string.IsNullOrWhiteSpace(id)) return null;
        return _catalog.FirstOrDefault(g => string.Equals(g.Id, id, StringComparison.OrdinalIgnoreCase));
    }

    public Game? GetFeaturedGame()
    {
        return _catalog.FirstOrDefault(g => g.IsFeatured) ?? _catalog.FirstOrDefault();
    }

    // --- Library Queries ---
    public IReadOnlyList<LibraryEntry> GetLibraryEntries() => _library.AsReadOnly();

    public LibraryEntry? GetLibraryEntry(string gameId)
    {
        return _library.FirstOrDefault(e => string.Equals(e.GameId, gameId, StringComparison.OrdinalIgnoreCase));
    }

    public bool IsInLibrary(string gameId)
    {
        return _library.Any(e => string.Equals(e.GameId, gameId, StringComparison.OrdinalIgnoreCase));
    }

    public List<(Game Game, LibraryEntry Entry)> GetLibraryGames()
    {
        var result = new List<(Game Game, LibraryEntry Entry)>();
        foreach (var entry in _library)
        {
            var game = GetGameById(entry.GameId);
            if (game != null)
            {
                result.Add((game, entry));
            }
        }
        return result;
    }

    public List<(Game Game, LibraryEntry Entry)> GetCurrentlyPlaying()
    {
        return GetLibraryGames()
            .Where(x => x.Entry.Status == GameStatus.Playing)
            .OrderByDescending(x => x.Entry.LastUpdated)
            .ToList();
    }

    public List<(Game Game, LibraryEntry Entry)> GetCompletedGames()
    {
        return GetLibraryGames()
            .Where(x => x.Entry.Status == GameStatus.Completed)
            .OrderByDescending(x => x.Entry.LastUpdated)
            .ToList();
    }

    public List<(Game Game, LibraryEntry Entry)> GetRecentlyAdded(int count = 4)
    {
        return GetLibraryGames()
            .OrderByDescending(x => x.Entry.DateAdded)
            .Take(count)
            .ToList();
    }

    // --- Statistics ---
    public int GetTotalLibraryCount() => _library.Count;
    public int GetPlayingCount() => _library.Count(e => e.Status == GameStatus.Playing);
    public int GetCompletedCount() => _library.Count(e => e.Status == GameStatus.Completed);
    public int GetWishlistCount() => _wishlist.Count;

    // --- Library Mutations ---
    public bool AddToLibrary(string gameId, GameStatus initialStatus = GameStatus.Backlog, int initialProgress = 0)
    {
        if (IsInLibrary(gameId)) return false;

        var game = GetGameById(gameId);
        if (game == null) return false;

        var entry = new LibraryEntry
        {
            GameId = game.Id,
            Status = initialStatus,
            ProgressPercentage = initialProgress,
            DateAdded = DateTime.UtcNow,
            LastUpdated = DateTime.UtcNow
        };

        _library.Insert(0, entry);
        AddActivity("LibraryAdd", $"Added {game.Title} to library", game.Id);

        _toast.ShowSuccess($"\"{game.Title}\" was added to your library!", "Added to Library");
        SaveAndNotify();
        return true;
    }

    public bool RemoveFromLibrary(string gameId)
    {
        var entry = GetLibraryEntry(gameId);
        if (entry == null) return false;

        var game = GetGameById(gameId);
        _library.Remove(entry);

        if (game != null)
        {
            AddActivity("LibraryRemove", $"Removed {game.Title} from library", game.Id);
            _toast.ShowInfo($"\"{game.Title}\" was removed from your library.", "Game Removed");
        }

        SaveAndNotify();
        return true;
    }

    public void UpdateLibraryEntry(string gameId, GameStatus status, int progress, int? rating, string notes)
    {
        var entry = GetLibraryEntry(gameId);
        if (entry == null) return;

        var game = GetGameById(gameId);
        var oldStatus = entry.Status;
        var oldProgress = entry.ProgressPercentage;

        entry.Status = status;
        entry.ProgressPercentage = progress;
        entry.PersonalRating = rating;
        entry.PersonalNotes = notes;
        entry.LastUpdated = DateTime.UtcNow;

        if (game != null)
        {
            if (status == GameStatus.Completed && oldStatus != GameStatus.Completed)
            {
                AddActivity("Completed", $"Completed {game.Title} 100%!", game.Id);
            }
            else if (status != oldStatus)
            {
                AddActivity("StatusChange", $"Changed {game.Title} status to {status}", game.Id);
            }
            else if (progress != oldProgress)
            {
                AddActivity("ProgressUpdate", $"Updated {game.Title} progress to {progress}%", game.Id);
            }
            _toast.ShowSuccess($"Saved changes for \"{game.Title}\"", "Library Updated");
        }

        SaveAndNotify();
    }

    // --- Wishlist Queries & Mutations ---
    public bool IsWishlisted(string gameId)
    {
        return _wishlist.Contains(gameId);
    }

    public List<Game> GetWishlistGames()
    {
        return _catalog.Where(g => _wishlist.Contains(g.Id)).ToList();
    }

    public bool ToggleWishlist(string gameId)
    {
        if (IsWishlisted(gameId))
        {
            RemoveFromWishlist(gameId);
            return false;
        }
        else
        {
            AddToWishlist(gameId);
            return true;
        }
    }

    public void AddToWishlist(string gameId)
    {
        if (_wishlist.Add(gameId))
        {
            var game = GetGameById(gameId);
            if (game != null)
            {
                AddActivity("WishlistAdd", $"Added {game.Title} to wishlist", game.Id);
                _toast.ShowSuccess($"\"{game.Title}\" added to wishlist", "Wishlist");
            }
            SaveAndNotify();
        }
    }

    public void RemoveFromWishlist(string gameId)
    {
        if (_wishlist.Remove(gameId))
        {
            var game = GetGameById(gameId);
            if (game != null)
            {
                _toast.ShowInfo($"\"{game.Title}\" removed from wishlist", "Wishlist");
            }
            SaveAndNotify();
        }
    }

    // --- Recommendations ---
    public List<Game> GetRecommendations(int count = 4)
    {
        var ownedIds = new HashSet<string>(_library.Select(e => e.GameId));
        var favGenre = _profile.FavoriteGenre;

        return _catalog
            .Where(g => !ownedIds.Contains(g.Id))
            .OrderByDescending(g => g.Genres.Any(genre => genre.Contains(favGenre, StringComparison.OrdinalIgnoreCase)))
            .ThenByDescending(g => g.Rating)
            .Take(count)
            .ToList();
    }

    // --- Activities ---
    public IReadOnlyList<ActivityEntry> GetRecentActivities(int count = 10)
    {
        return _activities.OrderByDescending(a => a.Timestamp).Take(count).ToList().AsReadOnly();
    }

    private void AddActivity(string type, string description, string? relatedGameId = null)
    {
        _activities.Insert(0, new ActivityEntry
        {
            Type = type,
            Description = description,
            Timestamp = DateTime.UtcNow,
            RelatedGameId = relatedGameId
        });

        if (_activities.Count > 50)
        {
            _activities = _activities.Take(50).ToList();
        }
    }

    // --- Profile & Preferences Mutations ---
    public async Task UpdateProfileAsync(UserProfile newProfile)
    {
        _profile.DisplayName = newProfile.DisplayName;
        _profile.Username = newProfile.Username;
        _profile.Bio = newProfile.Bio;
        _profile.FavoriteGenre = newProfile.FavoriteGenre;
        _profile.GamerLabel = newProfile.GamerLabel;
        _profile.AvatarInitials = newProfile.AvatarInitials;
        _profile.AvatarColor = newProfile.AvatarColor;

        _toast.ShowSuccess("Your profile has been updated.", "Profile Updated");
        SaveAndNotify();
    }

    public async Task UpdatePreferencesAsync(AppPreferences newPreferences)
    {
        _preferences = newPreferences;
        await _storage.ApplyDomPreferencesAsync(_preferences);
        _toast.ShowSuccess("Preferences saved successfully.", "Settings Updated");
        SaveAndNotify();
    }

    public async Task ResetDemoDataAsync()
    {
        _library = MockGameCatalog.GetInitialLibrary();
        _wishlist = new HashSet<string>(MockGameCatalog.GetInitialWishlist());
        _profile = new UserProfile();
        _preferences = new AppPreferences();
        _activities = MockGameCatalog.GetInitialActivities();

        await _storage.ClearStateAsync();
        await _storage.ApplyDomPreferencesAsync(_preferences);

        _toast.ShowSuccess("Demo data reset to factory state.", "Reset Complete");
        NotifyStateChanged();
    }

    private void SaveAndNotify()
    {
        var snapshot = new GameVaultSavedState
        {
            Version = 1,
            Library = _library,
            Wishlist = _wishlist.ToList(),
            Profile = _profile,
            Preferences = _preferences,
            Activities = _activities
        };

        _ = _storage.SaveStateAsync(snapshot);
        NotifyStateChanged();
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}
