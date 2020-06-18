using Factory.Ingredient;

namespace Factory.Pizza
{
    public class ChicagoCheesePizza : AbstractPizza
    {
        public override void Prepare()
        {
            _cheese = new GaudaCheese();
        }
    }
}