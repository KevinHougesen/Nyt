namespace MauiBlazorWeb.Shared.Services;
public class AppLinkReceivedEventArgs : EventArgs
{
    public required string Data { get; set; }
}
public class AppServices
{
    public event EventHandler<AppLinkReceivedEventArgs>? AppLinkReceived;
    public string? LastAppLink { get; private set; }

    public void OnAppLinkReceived(string data)
    {
        LastAppLink = data;

        AppLinkReceived?.Invoke(this, new() { Data = data });
    }
}