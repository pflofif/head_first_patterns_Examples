using Fabric.Pizza;

namespace Fabric.Fabrics;

internal class NyPizza : PizzaStore
{
    protected override Pizza.Pizza CreatePizza(string type)
    {
        return type switch
        {
            "cheese" => new NyCheesePizza(),
            "veggie" => new NyVeggiePizza(),
            "clam" => new NyClamPizza(),
            "pepperoni" => new NyPepperoniPizza(),
            _ => throw new KeyNotFoundException()
        };
    }
}