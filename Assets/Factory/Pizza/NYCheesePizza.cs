using Factory.Ingredient;

namespace Factory.Pizza
{
    public class NYCheesePizza : AbstractPizza
    {
        public override void Prepare()
        {
            _cheese = new BrieCheese();
        }
    }
}