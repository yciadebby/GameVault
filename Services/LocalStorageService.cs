using System.Text.Json;
using GameVault.Models;
using Microsoft.JSInterop;

namespace GameVault.Services;

public class GameVaultSavedState
{
    public int Version { get; set; } = 1;
    public List<LibraryEntry> Library { get; set; } = new();
    public List<string> Wishlist { get; set; } = new();
    public UserProfile Profile { get; set; } = new();
    public AppPreferences Preferences { get; set; } = new();
    public List<ActivityEntry> Activities { get; set; } = new();
}

public class LocalStorageService
{
    private const string StorageKey = "gamevault.state.v1";
    private readonly IJSRuntime _js;

    public LocalStorageService(IJSRuntime js)
    {
        _js = js;
    }

    public async Task<GameVaultSavedState?> LoadStateAsync()
    {
        try
        {
            var json = await _js.InvokeAsync<string?>("gamevaultStorage.getItem", StorageKey);
            if (string.IsNullOrWhiteSpace(json))
            {
                return null;
            }

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            return JsonSerializer.Deserialize<GameVaultSavedState>(json, options);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading state from localStorage: {ex.Message}");
            return null;
        }
    }

    public async Task SaveStateAsync(GameVaultSavedState state)
    {
        try
        {
            var json = JsonSerializer.Serialize(state);
            await _js.InvokeVoidAsync("gamevaultStorage.setItem", StorageKey, json);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving state to localStorage: {ex.Message}");
        }
    }

    public async Task ClearStateAsync()
    {
        try
        {
            await _js.InvokeVoidAsync("gamevaultStorage.removeItem", StorageKey);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error clearing localStorage: {ex.Message}");
        }
    }

    public async Task ApplyDomPreferencesAsync(AppPreferences preferences)
    {
        try
        {
            await _js.InvokeVoidAsync("gamevaultStorage.applyPreferences", preferences.Theme, preferences.AccentColor, preferences.ReducedMotion);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error applying DOM preferences: {ex.Message}");
        }
    }
}
