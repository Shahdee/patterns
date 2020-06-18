using Factory.AbstractFactory;
using Factory.Pizza;
using System;

namespace Factory.FactoryMethod
{
    public class NYPizzaStore : AbstractPizzaStore
    {
        private IIngredientFactory _ingredientFactory;
        
        public NYPizzaStore()
        {
            _ingredientFactory = new NYIngredientFactory();
        }

        protected override IPizza CreatePizza(EPizzaType pizzaType)
        {
            // Factory method approach 
            
            switch (pizzaType)
            {
                case EPizzaType.ClamPizza:
                    return new NYClamPizza();
            
                case EPizzaType.CheesePizza:
                    return new NYCheesePizza();
                
                default:
                    return null;
            }
            
            // Abstract factory approach 
            // switch (pizzaType)
            // {
            //     case EPizzaType.CheesePizza:
            //         return new CheesePizza(_ingredientFactory);
            //     
            //     case EPizzaType.ClamPizza:
            //         return new ClamPizza(_ingredientFactory);
            //     
            //     default:
            //         throw new NotImplementedException();
            // }
        }
    }
}