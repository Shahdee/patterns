using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CeilingFanOffCommand : ICommand
{
    CeilingFan fan;
    int prevSpeed;

    public CeilingFanOffCommand(CeilingFan f){
        fan = f;
    }

    public void Execute(){
        prevSpeed = fan.GetSpeed();
        fan.TurnOff();
    }

    public void Undo(){
        fan.Revert(prevSpeed);
    }
}
