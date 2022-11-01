namespace Decorator.Drinks;

public class Espresso : Drink
{
    public Espresso()
    {
        Description = "Espresso";
    }

    public override double Cost() => 1.99;
}