using System;
using Factory.AbstractFactory;
using Factory.Pizza;

namespace Factory.FactoryMethod
{
    public class ChicagoPizzaStore : AbstractPizzaStore
    {
        private IIngredientFactory _ingredientFactory;
        
        public ChicagoPizzaStore()
        {
            _ingredientFactory = new ChicagoIngredientFactory();
        }

        protected override IPizza CreatePizza(EPizzaType pizzaType)
        {
            
            // Factory method approach 
            
            switch (pizzaType)
            {
                case EPizzaType.ClamPizza:
                    return new ChicagoClamPizza();
            
                case EPizzaType.CheesePizza:
                    return new ChicagoCheesePizza();
                
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