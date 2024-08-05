using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;

using GetStarted.WinUI3.NavigationViewApp.Contracts.ViewModels;
using GetStarted.WinUI3.NavigationViewApp.Core.Contracts.Services;
using GetStarted.WinUI3.NavigationViewApp.Core.Models;

namespace GetStarted.WinUI3.NavigationViewApp.ViewModels;

public partial class DataGridViewModel : ObservableRecipient, INavigationAware
{
    private readonly ISampleDataService _sampleDataService;

    public ObservableCollection<SampleOrder> Source { get; } = new ObservableCollection<SampleOrder>();

    public DataGridViewModel(ISampleDataService sampleDataService)
    {
        _sampleDataService = sampleDataService;
    }

    public async void OnNavigatedTo(object parameter)
    {
        Source.Clear();

        // TODO: Replace with real data.
        var data = await _sampleDataService.GetGridDataAsync();

        foreach (var item in data)
        {
            Source.Add(item);
        }
    }

    public void OnNavigatedFrom()
    {
    }
}
