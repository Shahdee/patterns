using Factory.Ingredient;

namespace Factory.Pizza
{
    public class NYClamPizza : AbstractPizza
    {
        public override void Prepare()
        {
            _clams = new Clams();
        }
    }
}