using System.Runtime.CompilerServices;
using Fabric.Pizza;

namespace Fabric.Fabrics;

internal class CaliforniaPizza : PizzaStore
{
    private readonly Dictionary<string, Func<Pizza.Pizza>> _pizza = new();

    public CaliforniaPizza()
    {
        _pizza["cheese"] = () => new CaliforniaCheesePizza();
        _pizza["veggie"] = () => new CaliforniaVeggiePizza();
        _pizza["clam"] = () => new CaliforniaClamPizza();
        _pizza["pepperoni"] = () => new CaliforniaPepperoniPizza();
    }

    protected override Pizza.Pizza CreatePizza(string type)
    {
        _pizza.TryGetValue(type, out var pizza);
        return pizza?.Invoke() ?? throw new KeyNotFoundException();
    }

}