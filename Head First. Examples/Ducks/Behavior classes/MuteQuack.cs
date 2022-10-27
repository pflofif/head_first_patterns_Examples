using Head_First._Examples.Ducks.Interfaces;

namespace Head_First._Examples.Ducks.Behavior_classes;

public class MuteQuack : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("<<Silence>>");
    }
}