namespace GameVault.Models;

public class Game
{
    public string Id { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string ShortDescription { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string PrimaryGenre { get; set; } = string.Empty;
    public List<string> Genres { get; set; } = new();
    public DateTime ReleaseDate { get; set; }
    public double Rating { get; set; }
    public string Developer { get; set; } = string.Empty;
    public string Publisher { get; set; } = string.Empty;
    public List<string> Platforms { get; set; } = new();
    public List<string> Features { get; set; } = new();
    public string ArtTheme { get; set; } = string.Empty;
    public bool IsFeatured { get; set; }
}
