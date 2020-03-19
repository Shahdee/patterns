using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adapter : MonoBehaviour
{
    void Start()
    {
        Duck duck = new ConcreteDuck();
        Turkey turkey = new ConcreteTurkey();

        turkey.Fly();
        turkey.Gobble();

        Duck adapter = new TurkeyAdapter(turkey);     

        TestDuck(duck);
        TestDuck(adapter);
    }

    static void TestDuck(Duck d){
        d.Fly();
        d.Quack();
    }
}
