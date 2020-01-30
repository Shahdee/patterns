using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinnerState : State
{
    GumballMachine m_Machine;
    public WinnerState(GumballMachine machine){
        m_Machine = machine;
    }
    
    public void Insert(){
        Debug.Log("wait for gum");
    }

    public void Eject(){
        Debug.Log("too late");
    }

    public void Turn(){
        Debug.Log("cant turn now");
    }

    public void Dispense(){
         m_Machine.ReleaseBall();

         if (m_Machine.GetGumCount() == 0){
                Debug.Log("out of gumballs");
                m_Machine.SetState(m_Machine.GetOutState());
         }
         else{
             m_Machine.ReleaseBall();
             Debug.Log("you are a winner!");

            if (m_Machine.GetGumCount() > 0)
                m_Machine.SetState(m_Machine.GetNoQuarterState());
            else{
                Debug.Log("out of gumballs");
                m_Machine.SetState(m_Machine.GetOutState());
            }
         }
    }
}
