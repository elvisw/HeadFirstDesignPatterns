// See https://aka.ms/new-console-template for more information
using MiniDuckSimulator;

Duck mallard = new MallardDuck();
mallard.PerformQuack();
mallard.PerformFly();

Duck model = new ModelDuck();
model.PerformFly();
model.FlyBehavior = new FlyRocketPowered();
model.PerformFly();