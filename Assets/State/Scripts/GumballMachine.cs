using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GumballMachine : MonoBehaviour
{
    State m_NoQuarterState;
    State m_HasQuarterState;
    State m_OutState;
    State m_WinnerState;
    State m_SoldState;
    State m_CurrState;
    int m_Gums;

    static GumballMachine m_Instance;

    public static GumballMachine GetMachine(){
        return m_Instance;
    }

    public int GetGumCount(){
        return m_Gums;
    }

    void Awake(){

        m_Instance = this;

        m_NoQuarterState = new NoQuarterState(this);
        m_HasQuarterState = new HasQuarterState(this);
        m_OutState = new OutState(this);
        m_WinnerState = new WinnerState(this);
        m_SoldState = new SoldState(this);

        Fill(10);

        Test();
    }

    void Test(){

        Debug.LogWarning("1");

        Insert();
        Turn();

        Debug.LogWarning("2");

        Insert();
        Eject();
        Turn();

        Debug.LogWarning("3");

        Turn();

        Debug.LogWarning("4");

        Insert();
        Insert();
        Turn();
    }

    public void Fill(int gums){
        m_Gums = gums;

        if (m_Gums > 0){
            m_CurrState = m_NoQuarterState;
        }
        else{
            m_CurrState = m_OutState;
        }

        Debug.Log("machine filled " + m_Gums);
    }

    public void SetState(State state){
        m_CurrState = state;
    }

    public State GetHasQuarterState(){
        return m_HasQuarterState;
    }

    public State GetNoQuarterState(){
        return m_NoQuarterState;
    }

    public State GetOutState(){
        return m_OutState;
    }

    public State GetWinnerState(){
        return m_WinnerState;
    }

    public State GetSoldState(){
        return m_SoldState;
    }

    public void Eject(){
        m_CurrState.Eject();
    }

    public void Insert(){
        m_CurrState.Insert();
    }

    public void Turn(){
        m_CurrState.Turn();
        m_CurrState.Dispense();
    }

    public void ReleaseBall(){
        Debug.Log("release the ball");
        if (m_Gums > 0)
            m_Gums --;
    }
    
}
