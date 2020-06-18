using Factory.AbstractFactory;
using Factory.Ingredient;
using UnityEngine;

namespace Factory.Pizza
{
    public abstract class AbstractPizza : IPizza
    {
        protected ICheese _cheese;
        protected IClams _clams;

        public abstract void Prepare();

        public void Bake()
        {
            Debug.Log("baking");
        }

        public void Cut()
        {
            Debug.Log("cutting");
        }

        public void Pack()
        {
            Debug.Log("packing");
        }
    }
}