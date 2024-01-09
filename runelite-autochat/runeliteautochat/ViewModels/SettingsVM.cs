using System;
using Avalonia.Controls;
using System.Collections.ObjectModel;
using runeliteautochat.Models;
namespace runeliteautochat.ViewModels;

public class SettingsVM : ViewModelBase
{
    
    

    public SettingsVM()
    {
        TestBind = DataStore.RuneliteWindowTitle;
    }

    public string TestBind { get; set; }


}