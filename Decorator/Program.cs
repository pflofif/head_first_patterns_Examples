// See https://aka.ms/new-console-template for more information

using Decorator.DrinkDecorators;
using Decorator.Drinks;

var espresso = new Espresso(); // звичаний есперссо
Console.WriteLine(espresso.Description + " " + espresso.Cost());

var espressoWithAdd = new Whisp(new Mocha(new Mocha(espresso)));// завернули есперссо в декоратори
Console.WriteLine(espressoWithAdd.Description + " " + espressoWithAdd.Cost());

var houseBlendWithAdd = new Whisp(new Mocha(new Soy(new HouseBlend())));
Console.WriteLine(houseBlendWithAdd.Description + " " + houseBlendWithAdd.Cost());