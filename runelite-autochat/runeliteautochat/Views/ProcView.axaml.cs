using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using runeliteautochat.ViewModels;

namespace runeliteautochat.Views;

public partial class ProcView : UserControl
{
    public ProcView()
    {
        InitializeComponent();
        DataContext = new ProcViewVM();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}