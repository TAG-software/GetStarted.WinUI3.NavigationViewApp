namespace GetStarted.WinUI3.NavigationViewApp.Contracts.Services;

public interface IPageService
{
    Type GetPageType(string key);
}
