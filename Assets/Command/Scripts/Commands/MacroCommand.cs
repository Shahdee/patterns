using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MacroCommand : ICommand
{
    ICommand[] commands;

    public MacroCommand(ICommand[] cms){
        commands = cms;
    }

   public void Execute(){

       Debug.Log("mnacro on");

       for (int i=0; i<commands.Length;i++)
            commands[i].Execute();
   }

   public void Undo(){

        Debug.Log("mnacro undo");

        for (int i=0; i<commands.Length;i++)
            commands[i].Undo();
   }
}
