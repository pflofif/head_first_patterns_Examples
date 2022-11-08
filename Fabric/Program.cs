// See https://aka.ms/new-console-template for more information

using Fabric;
using Fabric.Fabrics;
using Fabric.Pizza;

PizzaStore nyPizza = new NyPizza();
Pizza pizza = nyPizza.OrderPizza("cheese");
Console.WriteLine(pizza);

PizzaStore californiaPizza = new CaliforniaPizza();
Pizza calPizza = californiaPizza.OrderPizza("clam");
Console.Write(calPizza);