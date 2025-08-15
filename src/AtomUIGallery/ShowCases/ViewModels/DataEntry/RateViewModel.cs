using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class RateViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "RateShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public RateViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}