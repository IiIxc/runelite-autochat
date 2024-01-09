using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using runeliteautochat.ViewModels;

namespace runeliteautochat.Views;

public partial class SettingsView : UserControl
{
    public SettingsView()
    {
        InitializeComponent();
        DataContext = new SettingsVM();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}