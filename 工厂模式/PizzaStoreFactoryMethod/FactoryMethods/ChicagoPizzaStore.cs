using PizzaStoreFactoryMethod.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreFactoryMethod.FactoryMethods
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string item)
        {
            Pizza pizza = null;

            switch (item)
            {
                case "cheese":
                    pizza = new ChicagoStyleCheesePizza();
                    break;
                case "veggie":
                    pizza = new ChicagoStyleVeggiePizza();
                    break;
                case "clam":
                    pizza = new ChicagoStyleClamPizza();
                    break;
                case "pepperoni":
                    pizza = new ChicagoStylePepperoniPizza();
                    break;
            }

            return pizza;
        }
    }
}
