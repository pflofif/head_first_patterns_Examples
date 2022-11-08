using System.Security.Cryptography;
using Fabric.Pizza;

namespace Fabric;

public abstract class PizzaStore
{
    public Pizza.Pizza OrderPizza(string type)
    {
        var pizza = CreatePizza(type);

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();
        return pizza;
    }

    protected abstract Pizza.Pizza CreatePizza(string type);
}
