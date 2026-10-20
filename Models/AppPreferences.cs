namespace GameVault.Models;

public class AppPreferences
{
    public string Theme { get; set; } = "Dark"; // "Dark" or "Light"
    public string AccentColor { get; set; } = "Violet"; // "Violet", "Cyan", "Blue"
    public string DefaultLibraryView { get; set; } = "Grid"; // "Grid" or "List"
    public string CardDensity { get; set; } = "Comfortable"; // "Comfortable" or "Compact"
    public bool ShowRatings { get; set; } = true;
    public bool ReducedMotion { get; set; } = false;
    public bool GameUpdatesNotification { get; set; } = true;
    public bool WishlistRemindersNotification { get; set; } = true;
    public bool AchievementAlertsNotification { get; set; } = true;
}
