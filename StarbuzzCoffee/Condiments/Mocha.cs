using StarbuzzCoffee.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbuzzCoffee.Condiments
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
        {
            PBeverage = beverage;
        }
        public override string Description => PBeverage.Description + ", Mocha";
        public override double Cost { get => PBeverage.Cost + 0.2; }
    }
}
