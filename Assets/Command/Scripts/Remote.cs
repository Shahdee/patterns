using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// using 

// invoker 
// could be joystick 
public class Remote 
{
    // public delegate void CustomAction<T1,T2,T3>(T1 t1, T2 t2, T3 t3);

    // public CustomAction<int, int, int> onCommandExecute;

    public delegate void CustomAction();

    public const int COMMAND_NUM = 7;
    ICommand[] m_OnCommands = new ICommand[COMMAND_NUM];
    ICommand[] m_OffCommands = new ICommand[COMMAND_NUM];

    CustomAction onAction;
    CustomAction offAction;

    Stack<ICommand> undoStack = new Stack<ICommand>();

    static Remote m_Instance;

    public void SetSlotCommand(int slotId, ICommand onCommand, ICommand offCommand){
        m_OnCommands[slotId] = onCommand;
        m_OffCommands[slotId] = offCommand;

        CustomAction action = TestMethod;
        action();
    }

    void TestMethod(){
        // Debug.Log("a " + a + " b " + b + " c " + c);
    }

    public void SetSlotCommand(int id, CustomAction action1, CustomAction action2){
        onAction = action1;
        offAction = action2;
    }

    public void ClickOn(int slotId){

        onAction();

        // m_OnCommands[slotId].Execute();
        // undoStack.Push(m_OnCommands[slotId]);
    }

    public void ClickOff(int slotId){

        offAction();
        
        // m_OffCommands[slotId].Execute();
        // undoStack.Push(m_OffCommands[slotId]);
    }

    public void ClickUndo(){
        if (undoStack.Count > 0){
            ICommand currUndo = undoStack.Pop();
            currUndo.Undo();
        }  
        else{
            Debug.Log("can't undo");
        }    
    }

    public override string ToString(){
    
        string s = ("---remote control\n");
        
        for (int i=0; i<m_OnCommands.Length; i++){
            if (m_OnCommands[i] != null)
                s += (" [slot " + i + "] " + m_OnCommands[i].GetType() + "  " + m_OffCommands[i].GetType() + "\n");
        }
        return s;
    }
}
