using UnityEngine;
using Factory.FactoryMethod;
using Factory.Pizza;

namespace Factory
{
    public class Factory : MonoBehaviour
    {
        void Start()
        {
            var chicagoStore = new ChicagoPizzaStore();
            var nyStore = new NYPizzaStore();

            var chicagoClams = chicagoStore.PreparePizza(EPizzaType.ClamPizza);
            var nyCheese = nyStore.PreparePizza(EPizzaType.CheesePizza);
        }
    }
}