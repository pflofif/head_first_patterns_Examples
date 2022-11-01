using Decorator.Drinks;

namespace Decorator.DrinkDecorators;

public class Mocha : DrinkDecorator
{
    private readonly Drink _drink;

    public Mocha(Drink drink)
    {
        _drink = drink;
        Description = $"{_drink.Description} + Mocha";
    }

    public override double Cost()
    {
        return 0.20 + _drink.Cost();
    }
}