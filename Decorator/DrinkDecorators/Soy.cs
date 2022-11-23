using Decorator.Drinks;

namespace Decorator.DrinkDecorators;

public class Soy : DrinkDecorator
{

    public Soy(Drink drink)
    : base(drink, "Soy")
    {
    }

    public override double Cost()
    {
        return 0.35 + _drink.Cost();
    }
}