using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Duck 
{
    void Fly();
    void Quack();
}

public interface Turkey{
    void Gobble();
    void Fly();
}


public class ConcreteDuck : Duck {

    public void Fly(){
        Debug.Log("fly");
    }
    
    public void Quack(){
        Debug.Log("quack");
    }
}
public class ConcreteTurkey : Turkey {

    public void Fly(){
        Debug.Log("short fly");
    }
    
    public void Gobble(){
        Debug.Log("gobble");
    }
}


public class TurkeyAdapter : Duck {

    Turkey turkey;

    public TurkeyAdapter(Turkey tk){
        turkey = tk;
    }

    public void Fly(){
        for (int i=0; i<3; i++)
            turkey.Fly();
    }

    public void Quack(){
        turkey.Gobble();
    }
}

public class DuckAdapter : Turkey {

    Duck duck;

    public DuckAdapter(Duck d){
        duck = d;
    }

    public void Fly(){
        duck.Fly();
    }

    public void Gobble(){
        duck.Quack();
    }
}