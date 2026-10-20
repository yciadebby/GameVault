namespace GameVault.Services;

public enum ToastLevel
{
    Info,
    Success,
    Warning,
    Error
}

public class ToastMessage
{
    public string Id { get; } = Guid.NewGuid().ToString("N");
    public string Title { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
    public ToastLevel Level { get; set; } = ToastLevel.Info;
    public DateTime CreatedAt { get; } = DateTime.UtcNow;
}

public class ToastService
{
    public event Action? OnChange;
    private readonly List<ToastMessage> _toasts = new();

    public IReadOnlyList<ToastMessage> Toasts => _toasts.AsReadOnly();

    public void ShowToast(string message, string title = "", ToastLevel level = ToastLevel.Info)
    {
        var toast = new ToastMessage
        {
            Title = string.IsNullOrWhiteSpace(title) ? GetDefaultTitle(level) : title,
            Message = message,
            Level = level
        };

        _toasts.Add(toast);
        NotifyStateChanged();

        // Auto-remove after 4 seconds
        _ = Task.Delay(4000).ContinueWith(_ =>
        {
            RemoveToast(toast.Id);
        });
    }

    public void ShowSuccess(string message, string title = "Success") => ShowToast(message, title, ToastLevel.Success);
    public void ShowError(string message, string title = "Error") => ShowToast(message, title, ToastLevel.Error);
    public void ShowWarning(string message, string title = "Notice") => ShowToast(message, title, ToastLevel.Warning);
    public void ShowInfo(string message, string title = "Information") => ShowToast(message, title, ToastLevel.Info);

    public void RemoveToast(string id)
    {
        var item = _toasts.FirstOrDefault(t => t.Id == id);
        if (item != null)
        {
            _toasts.Remove(item);
            NotifyStateChanged();
        }
    }

    private void NotifyStateChanged() => OnChange?.Invoke();

    private static string GetDefaultTitle(ToastLevel level) => level switch
    {
        ToastLevel.Success => "Success",
        ToastLevel.Error => "Error",
        ToastLevel.Warning => "Attention",
        _ => "Information"
    };
}
