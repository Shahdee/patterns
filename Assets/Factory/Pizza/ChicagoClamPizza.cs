using Factory.Ingredient;

namespace Factory.Pizza
{
    public class ChicagoClamPizza : AbstractPizza
    {
        public override void Prepare()
        {
            _clams = new FrozenClams();
        }
    }
}