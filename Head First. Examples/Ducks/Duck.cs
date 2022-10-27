using Head_First._Examples.Ducks.Interfaces;

namespace Head_First._Examples.Ducks;

public abstract class Duck
{
    private readonly IFlyBehavoir _flyBehavior;
    private readonly IQuackBehavior _quackBehavior;

    protected Duck(IFlyBehavoir flyBehavior, IQuackBehavior quackBehavior)
    {
        _flyBehavior = flyBehavior;
        _quackBehavior = quackBehavior;
    }

    public void Quack()
    {
        _quackBehavior.Quack();
    }

    public void Fly()
    {
        _flyBehavior.Fly();
    }

    public abstract void Swim();
}