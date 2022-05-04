using StarbuzzCoffee.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbuzzCoffee.Condiments
{
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage)
        {
            PBeverage = beverage;
        }
        public override string Description => PBeverage.Description + ", Soy";
        public override double Cost => 0.15 + PBeverage.Cost;
    }
}
