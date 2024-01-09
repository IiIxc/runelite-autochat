namespace runeliteautochat.Models;

public class ProcessModel
{
    public string Title { get; set; }
    public int ProcId{ get; set; }

    public ProcessModel(string title, int procId)
    {
        Title = title;
        ProcId = procId;
    }
}