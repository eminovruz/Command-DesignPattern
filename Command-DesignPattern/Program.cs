public interface ICommand
{
    public void Execute();
}

public class SaveButton : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Project Saved!");
    }
}

public class AddButton : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Project Added!");
    }
}

public class DeleteButton : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Project Deleted!");
    }
}


public class Button
{
    ICommand? _command;

    public Button(ICommand command)
    {
        _command = command;
    }
}

