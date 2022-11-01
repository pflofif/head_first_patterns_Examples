using Decorator.Drinks;

namespace Decorator.DrinkDecorators;

public class Whisp : DrinkDecorator
{
    private readonly Drink _drink;

    public Whisp(Drink drink)
    {
        _drink = drink;
        Description = $"{_drink.Description} + Whisp";
    }

    public override double Cost()
    {
        return 0.15 + _drink.Cost();
    }
}