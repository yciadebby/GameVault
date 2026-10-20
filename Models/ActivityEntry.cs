namespace GameVault.Models;

public class ActivityEntry
{
    public string Id { get; set; } = Guid.NewGuid().ToString("N");
    public string Type { get; set; } = string.Empty; // "LibraryAdd", "StatusChange", "ProgressUpdate", "WishlistAdd", "Completed"
    public string Description { get; set; } = string.Empty;
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    public string? RelatedGameId { get; set; }
}
