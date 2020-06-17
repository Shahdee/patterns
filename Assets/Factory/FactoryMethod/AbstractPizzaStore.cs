using Factory.Pizza;

namespace Factory.FactoryMethod
{
    public abstract class AbstractPizzaStore
    {

        public IPizza PreparePizza(EPizzaType pizzaType)
        {
            IPizza pizza = CreatePizza(pizzaType);

            pizza.Bake();
            pizza.Cut();
            pizza.Pack();

            return pizza;
        }

        protected abstract IPizza CreatePizza(EPizzaType pizzaType);
    }
}