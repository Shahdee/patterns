
using UnityEngine;

public class HasQuarterState : State
{
    GumballMachine m_Machine;
    public HasQuarterState(GumballMachine machine){
        m_Machine = machine;
    }

    public void Insert(){
        Debug.Log("cant insert another coin");
    }

    public void Eject(){
        Debug.Log("coin ejected");
        m_Machine.SetState(m_Machine.GetNoQuarterState());
    }

    public void Turn(){
        Debug.Log("crank turned");

        float num = Random.Range(0f, 1f);

        Debug.Log("num= " + num);

        if (num <= 0.1f && (m_Machine.GetGumCount() > 1)) // 10% chance & enough gums 
            m_Machine.SetState(m_Machine.GetWinnerState());
        else
            m_Machine.SetState(m_Machine.GetSoldState());
    }

    public void Dispense(){
        Debug.Log("cant dispense");
    }
    
}
