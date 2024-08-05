using GetStarted.WinUI3.NavigationViewApp.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace GetStarted.WinUI3.NavigationViewApp.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}
