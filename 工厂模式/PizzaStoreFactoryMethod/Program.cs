// See https://aka.ms/new-console-template for more information

using PizzaStoreFactoryMethod.FactoryMethods;
using PizzaStoreFactoryMethod.Pizzas;

PizzaStore nyStore = new NYPizzaStore();
PizzaStore chicagoStore = new ChicagoPizzaStore();

Pizza pizza = nyStore.OrderPizza("cheese");
Console.WriteLine($"Ethan ordered a {pizza.Name}\n");

pizza = chicagoStore.OrderPizza("cheese");
Console.WriteLine($"Joel ordered a {pizza.Name}\n");