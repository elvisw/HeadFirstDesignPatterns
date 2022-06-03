namespace PizzaStoreAbstractFactory.Ingredients
{
    public class Mushroom : IVeggies
    {
        string IVeggies.ToString()
        {
            return "Mushrooms";
        }
    }
}
