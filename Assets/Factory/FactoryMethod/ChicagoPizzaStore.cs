using Factory.Pizza;

namespace Factory.FactoryMethod
{
    public class ChicagoPizzaStore : AbstractPizzaStore
    {
        protected override IPizza CreatePizza(EPizzaType pizzaType)
        {
            switch (pizzaType)
            {
                case EPizzaType.ClamPizza:
                    return new ChicagoClamPizza();

                case EPizzaType.CheesePizza:
                    return new ChicagoCheesePizza();
                
                default:
                    return null;
            }
        }
    }
}