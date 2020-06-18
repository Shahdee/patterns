using Factory.Ingredient;

namespace Factory.AbstractFactory
{
    public class ChicagoIngredientFactory : IIngredientFactory
    {
        public ICheese CreateCheese()
        {
            return new GaudaCheese();
        }

        public IClams CreateClams()
        {
            return new FrozenClams();
        }
    }
}