using StarbuzzCoffee.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbuzzCoffee.Condiments
{
    public abstract class CondimentDecorator : Beverage
    {
        public Beverage? PBeverage { get; set; }
        public abstract override string Description { get; }
    }
}
