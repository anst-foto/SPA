using System.Reactive;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace SPA.ViewModels.Pages;

public class MainPageViewModel : ViewModelBase
{
    [Reactive] public string Test { get; set; }
    public ReactiveCommand<Unit, Unit> CommandChange { get;}

    public MainPageViewModel()
    {
        Title = "Main Page";
        Test = App.Current.Resources["Test"].ToString();

        CommandChange = ReactiveCommand.Create(() =>
        {
            App.Current.Resources["Test"] = "Changed";
        });
    }
}