using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbuzzCoffee.Beverages
{
    public abstract class Beverage
    {
        public virtual string Description { get; protected set; } = "Unknown Beverage";
        public abstract double Cost { get; }
    }
}
