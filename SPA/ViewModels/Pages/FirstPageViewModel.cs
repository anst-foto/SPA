using System.Reactive;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace SPA.ViewModels.Pages;

public class FirstPageViewModel : ViewModelBase
{
    [Reactive] public string Header { get; set; } = App.Current.Resources["Test"].ToString();
    public ReactiveCommand<Unit, Unit> CommandRefresh { get; }

    public FirstPageViewModel()
    {
        CommandRefresh = ReactiveCommand.CreateFromTask(async () =>
        {
            await Task.Delay(1000);
            Header = App.Current.Resources["Test"].ToString();
        });
    }
}