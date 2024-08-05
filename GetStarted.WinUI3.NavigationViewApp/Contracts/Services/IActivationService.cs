namespace GetStarted.WinUI3.NavigationViewApp.Contracts.Services;

public interface IActivationService
{
    Task ActivateAsync(object activationArgs);
}
