using Head_First._Examples.Ducks.Interfaces;

namespace Head_First._Examples.Ducks.Behavior_classes;

public class FlyNoWay : IFlyBehavoir
{
    public void Fly()
    {
        Console.WriteLine("Cant Fly");
    }
}