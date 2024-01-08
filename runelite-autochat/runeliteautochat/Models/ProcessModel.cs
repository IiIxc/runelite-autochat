namespace runeliteautochat.Models;

public class ProcessModel
{
    public string Title { get; set; }
    public int Number{ get; set; }

    public ProcessModel(string title, int number)
    {
        Title = title;
        Number = number;
    }
}