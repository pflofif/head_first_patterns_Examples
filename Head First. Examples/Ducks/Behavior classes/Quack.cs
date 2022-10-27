using Head_First._Examples.Ducks.Interfaces;

namespace Head_First._Examples.Ducks.Behavior_classes;

public class NormalQuack : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Quack");
    }
}