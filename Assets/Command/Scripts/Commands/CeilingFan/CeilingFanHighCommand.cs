using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CeilingFanHighCommand : ICommand
{
    CeilingFan fan;
    int prevSpeed;

    public CeilingFanHighCommand(CeilingFan f){
        fan = f;
    }

    public void Execute(){
        prevSpeed = fan.GetSpeed();
        fan.SetHighSpeed();
    }

    public void Undo(){
        fan.Revert(prevSpeed);
    }
}
