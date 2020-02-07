using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CeilingFanLowCommand : ICommand
{
    CeilingFan fan;
    int prevSpeed;

    public CeilingFanLowCommand(CeilingFan f){
        fan = f;
    }

    public void Execute(){
        prevSpeed = fan.GetSpeed();
        fan.SetLowSpeed();
    }

    public void Undo(){
        fan.Revert(prevSpeed);
    }
}
