using Decorator.Drinks;

namespace Decorator.DrinkDecorators;

public class Soy : DrinkDecorator
{
    private readonly Drink _drink;

    public Soy(Drink drink)
    {
        _drink = drink;
        Description = $"{_drink.Description} + Soy";
    }

    public override double Cost()
    {
        return 0.35 + _drink.Cost();
    }
}