using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniDuckSimulator
{
    public abstract class Duck
    {
        //private FlyBehavior _flyBehavior;
        //private QuakcBehavior _quakcBehavior;

        public IFlyBehavior FlyBehavior { get; set; }
        public IQuackBehavior QuakcBehavior { get; set; }

        public abstract void Display();

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }
        public void PerformQuack()
        {
            QuakcBehavior.Quack();
        }
        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys.");
        }        

    }
}
