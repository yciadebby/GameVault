namespace GameVault.Models;

public class LibraryEntry
{
    public string GameId { get; set; } = string.Empty;
    public GameStatus Status { get; set; } = GameStatus.Backlog;
    
    private int _progressPercentage;
    public int ProgressPercentage
    {
        get => _progressPercentage;
        set => _progressPercentage = Math.Clamp(value, 0, 100);
    }

    public int? PersonalRating { get; set; } // 1 to 5
    public string PersonalNotes { get; set; } = string.Empty;
    public DateTime DateAdded { get; set; } = DateTime.UtcNow;
    public DateTime LastUpdated { get; set; } = DateTime.UtcNow;
}
