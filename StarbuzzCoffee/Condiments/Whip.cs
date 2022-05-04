using StarbuzzCoffee.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbuzzCoffee.Condiments
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage)
        {
            PBeverage = beverage;
        }
        public override string Description => PBeverage.Description + ", Whip ";
        public override double Cost { get => PBeverage.Cost + 0.1; }
    }
}
