using ReactiveUI;

namespace SPA.ViewModels;

public class ViewModelBase : ReactiveObject
{
    public string? Title { get; protected set; }
}