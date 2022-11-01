using Decorator.Drinks;

namespace Decorator.DrinkDecorators;

public abstract class DrinkDecorator : Drink
{

}

public class Mocha : DrinkDecorator
{
    private readonly Drink _drink;
    private double averageTempOnMars = 123123;

    public Mocha(Drink drink)
    {
        _drink = drink;
        Description = $"{_drink.Description} + Mocha";
    }

    public override double Cost()
    {
        return 0.20 + _drink.Cost() + averageTempOnMars;
    }
}