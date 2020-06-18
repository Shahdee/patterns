using Factory.AbstractFactory;

namespace Factory.Pizza
{
    public class ClamPizza : AbstractPizza
    {
        protected IIngredientFactory _factory;
        
        public ClamPizza(IIngredientFactory factory)
        {
            _factory = factory;
        }
        
        public override void Prepare()
        {
            _clams = _factory.CreateClams();
        }
    }
}