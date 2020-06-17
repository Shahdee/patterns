using Factory.Pizza;

namespace Factory.FactoryMethod
{
    public class NYPizzaStore : AbstractPizzaStore
    {
        protected override IPizza CreatePizza(EPizzaType pizzaType)
        {
            switch (pizzaType)
            {
                case EPizzaType.ClamPizza:
                    return new NYClamPizza();

                case EPizzaType.CheesePizza:
                    return new NYCheesePizza();
                
                default:
                    return null;
            }
        }
    }
}