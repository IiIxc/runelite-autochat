using ReactiveUI;
using runeliteautochat.Models;

namespace runeliteautochat.ViewModels;

public class ViewModelBase : ReactiveObject
{

    public SharedDataStore DataStore { get; set; }

    public ViewModelBase()
    {
        DataStore = new SharedDataStore();
        DataStore.RuneliteWindowTitle = "fdjks;sdfjk";
    }
    
}
