using Factory.AbstractFactory;

namespace Factory.Pizza
{
    public class CheesePizza : AbstractPizza
    {
        protected IIngredientFactory _factory;
        
        public CheesePizza(IIngredientFactory factory)
        {
            _factory = factory;
        }

        public override void Prepare()
        {
            _cheese = _factory.CreateCheese();
        }
    }
}