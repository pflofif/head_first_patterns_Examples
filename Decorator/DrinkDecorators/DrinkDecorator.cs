using Decorator.Drinks;

namespace Decorator.DrinkDecorators;

public abstract class DrinkDecorator : Drink
{
    protected readonly Drink _drink;

    protected DrinkDecorator(Drink drink, string desc)
    {
        _drink = drink;
        Description = $"{_drink.Description} " + desc;
    }
}