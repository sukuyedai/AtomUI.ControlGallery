using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class RateShowCase : ReactiveUserControl<RateViewModel>
{
    public RateShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
    }
}