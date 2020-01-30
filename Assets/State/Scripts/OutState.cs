using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutState : State
{
    GumballMachine m_Machine;
    public OutState(GumballMachine machine){
        m_Machine = machine;
    }
    
    public void Insert(){
        Debug.Log("empty machine");
    }

    public void Eject(){
        Debug.Log("empty machine");
    }

    public void Turn(){
        Debug.Log("empty machine");
    }

    public void Dispense(){
        Debug.Log("empty machine");
    }
}
