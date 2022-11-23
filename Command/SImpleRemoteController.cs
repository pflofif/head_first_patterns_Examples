namespace Command;

public class SimpleRemoteController
{
    private ICommand? _command;

    public SimpleRemoteController()
    {
        
    }

    public void SetCommand(ICommand? newCommand) => _command = newCommand;
    public void BurronWasPressed() => _command?.Execute();
}