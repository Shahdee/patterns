using Factory.Ingredient;

namespace Factory.AbstractFactory
{
    public interface IIngredientFactory
    {
        ICheese CreateCheese();

        IClams CreateClams();
    }
}