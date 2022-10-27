using Head_First._Examples.Ducks.Interfaces;

namespace Head_First._Examples.Ducks;

public class MallarDuck : Duck
{
    public override void Swim()
    {
        Console.WriteLine("Swim");
    }

    public MallarDuck(IFlyBehavoir flyBehavior, IQuackBehavior quackBehavior) 
        : base(flyBehavior, quackBehavior)
    {
    }
}