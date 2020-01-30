using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoQuarterState : State
{
    GumballMachine m_Machine;
    public NoQuarterState(GumballMachine machine){
        m_Machine = machine;
    }

    public void Insert(){
        Debug.Log("you inserted a coin");
        m_Machine.SetState(m_Machine.GetHasQuarterState());
    }

    public void Eject(){
        Debug.Log("no coin inserted");
    }

    public void Turn(){
        Debug.Log("no coin inserted");
    }

    public void Dispense(){
        Debug.Log("no coin inserted");
    }
}
