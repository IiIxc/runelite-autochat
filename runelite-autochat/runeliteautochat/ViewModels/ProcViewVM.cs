using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Avalonia.Interactivity;
using runeliteautochat.Models;

namespace runeliteautochat.ViewModels;

public class ProcViewVM : ViewModelBase
{
    public ObservableCollection<ProcessModel> ActiveProcesses { get; set; }
    
    public ProcViewVM()
    {
        CheckForProcesses();
    }

    Object CheckForProcesses()
    {
        Process[] RuneLiteProcesses = Process.GetProcessesByName("RuneLite");


        ActiveProcesses = new ObservableCollection<ProcessModel> {};
        
        foreach (var process in RuneLiteProcesses)
        {
            ActiveProcesses.Add(new ProcessModel(process.MainWindowTitle,process.Id));
        }

        return ActiveProcesses;
    }

}