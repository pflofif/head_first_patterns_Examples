using Decorator.Drinks;

namespace Decorator.DrinkDecorators;

public class Mocha : DrinkDecorator
{

    public Mocha(Drink drink) 
        : base(drink, "Mocha")
    {
    }

    public override double Cost()
    {
        return 0.20 + _drink.Cost();
    }
}