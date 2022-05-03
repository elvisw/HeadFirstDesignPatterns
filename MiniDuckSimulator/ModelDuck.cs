using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniDuckSimulator
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuakcBehavior = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model duck"); ;
        }
    }
}
