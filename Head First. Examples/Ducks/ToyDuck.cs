using Head_First._Examples.Ducks.Interfaces;

namespace Head_First._Examples.Ducks;

public class ToyDuck : Duck
{
    public ToyDuck(IFlyBehavoir flyBehavior, IQuackBehavior quackBehavior)
        : base(flyBehavior, quackBehavior)
    {
    }

    public override void Swim()
    {
        Console.WriteLine("Toy Swim");
    }
}