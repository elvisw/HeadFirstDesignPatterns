namespace PizzaStoreAbstractFactory.Ingredients
{
    public class FreshClams : IClams
    {
        string IClams.ToString()
        {
            return "Fresh Clams from Long Island Sound";
        }
    }
}
