
using PizzaStoreAbstractFactory.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreAbstractFactory.FactoryMethods
{
    public abstract class PizzaStore
    {
        protected abstract Pizza CreatePizza(string item);

        public Pizza OrderPizza(string type)
        {
            Pizza pizza = CreatePizza(type);
            Console.WriteLine("--- Making a " + pizza.Name + " ---");
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }
}
