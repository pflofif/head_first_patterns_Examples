namespace Decorator.Drinks;

public class HouseBlend : Drink
{
    public HouseBlend()
    {
        Description = "HouseBlend";
    }

    public override double Cost() => 0.99;
}