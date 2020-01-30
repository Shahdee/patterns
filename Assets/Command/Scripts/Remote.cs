using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// invoker 
// could be joystick 
public class Remote 
{
    public const int COMMAND_NUM = 7;
    Command[] m_OnCommands = new Command[COMMAND_NUM];
    Command[] m_OffCommands = new Command[COMMAND_NUM];

    static Remote m_Instance;

    public void SetSlotCommand(int slotId, Command onCommand, Command offCommand){
        m_OnCommands[slotId] = onCommand;
        m_OffCommands[slotId] = offCommand;
    }

    public void ClickOn(int slotId){
        m_OnCommands[slotId].Execute();
    }

    public void ClickOff(int slotId){
        m_OffCommands[slotId].Execute();
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
