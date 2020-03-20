using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decorator : MonoBehaviour
{
    void Start()
    {
        Beverage espress = new Espresso();
        Debug.Log(espress.GetDescription() + " " + espress.GetCost());

        Beverage darkRoast = new DarkRoast();
        darkRoast = new Mocha(darkRoast);
        darkRoast = new Mocha(darkRoast);
        darkRoast = new Whip(darkRoast);
        Debug.Log(darkRoast.GetDescription() + " " + darkRoast.GetCost());

        Beverage house = new HouseBlend();
        house = new Soy(house);
        house = new Mocha(house);
        house = new Whip(house);
        Debug.Log(house.GetDescription() + " " + house.GetCost());
    }

}
