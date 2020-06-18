using Factory.Ingredient;

namespace Factory.AbstractFactory
{
    public class NYIngredientFactory : IIngredientFactory
    {
        public ICheese CreateCheese()
        {
            return new BrieCheese();
        }

        public IClams CreateClams()
        {
            return new Clams();
        }
    }
}