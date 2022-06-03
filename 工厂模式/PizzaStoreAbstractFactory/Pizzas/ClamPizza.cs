using PizzaStoreAbstractFactory.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreAbstractFactory.Pizzas
{
    public class ClamPizza : Pizza
    {
        private readonly IPizzaIngredientFactory _ingredientFactory;

        public ClamPizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Dough = _ingredientFactory.CreateDough();
            Sauce = _ingredientFactory.CreateSauce();
            Cheese = _ingredientFactory.CreateCheese();
            Clam = _ingredientFactory.CreateClam();
        }
    }
}
