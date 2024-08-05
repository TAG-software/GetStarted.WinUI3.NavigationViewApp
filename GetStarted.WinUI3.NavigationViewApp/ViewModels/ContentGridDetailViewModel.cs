using CommunityToolkit.Mvvm.ComponentModel;

using GetStarted.WinUI3.NavigationViewApp.Contracts.ViewModels;
using GetStarted.WinUI3.NavigationViewApp.Core.Contracts.Services;
using GetStarted.WinUI3.NavigationViewApp.Core.Models;

namespace GetStarted.WinUI3.NavigationViewApp.ViewModels;

public partial class ContentGridDetailViewModel : ObservableRecipient, INavigationAware
{
    private readonly ISampleDataService _sampleDataService;

    [ObservableProperty]
    private SampleOrder? item;

    public ContentGridDetailViewModel(ISampleDataService sampleDataService)
    {
        _sampleDataService = sampleDataService;
    }

    public async void OnNavigatedTo(object parameter)
    {
        if (parameter is long orderID)
        {
            var data = await _sampleDataService.GetContentGridDataAsync();
            Item = data.First(i => i.OrderID == orderID);
        }
    }

    public void OnNavigatedFrom()
    {
    }
}
