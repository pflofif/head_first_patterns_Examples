// See https://aka.ms/new-console-template for more information

using Head_First._Examples.Ducks;
using Head_First._Examples.Ducks.Behavior_classes;

// Паттерн Стратегія
// поведінка задається динамічно через "класи поведінки"

Console.WriteLine("-----mallar Duck-----");
var mallarDuck = new MallarDuck(new FlyWithWings(), new NormalQuack());
mallarDuck.Quack();
mallarDuck.Fly();
mallarDuck.Swim();
Console.WriteLine(new string('-',21));

Console.WriteLine("-----Toy Duck-----");
var toyDuck = new ToyDuck(new FlyNoWay(), new NormalQuack());
toyDuck.Quack();
toyDuck.Fly();
toyDuck.Swim();
Console.WriteLine(new string('-', 21));