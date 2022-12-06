namespace Command;

public class SimpleRemoteController
{
    private readonly List<Action> _onCommand;
    private readonly List<Action> _offCommand;

    public SimpleRemoteController(int devicesCount = 7)
    {
        _onCommand = new List<Action>();
        _offCommand = new List<Action>();
        for (int i = 0; i < devicesCount; i++)
        {
            _onCommand.Add(() => { });
            _offCommand.Add(() => { });
        }
    }

    public void SetCommand(int slot , Action onCommand, Action offCommand) 
        => (_onCommand[slot], _offCommand[slot]) = (onCommand, offCommand);
    public void OnBurronWasPressed(int slot) => _onCommand[slot].Invoke();
    public void OffBurronWasPressed(int slot) => _offCommand[slot].Invoke();
}