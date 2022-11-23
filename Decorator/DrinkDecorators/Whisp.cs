using Decorator.Drinks;

namespace Decorator.DrinkDecorators;

public class Whisp : DrinkDecorator
{
    public Whisp(Drink drink) : base(drink, "Whisp")
    {
    }

    public override double Cost()
    {
        return 0.15 + _drink.Cost();
    }
}