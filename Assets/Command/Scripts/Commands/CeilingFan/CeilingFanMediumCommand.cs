using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CeilingFanMediumCommand : ICommand
{
    CeilingFan fan;
    int prevSpeed;

    public CeilingFanMediumCommand(CeilingFan f){
        fan = f;
    }

    public void Execute(){
        prevSpeed = fan.GetSpeed();
        fan.SetMediumSpeed();
    }

    public void Undo(){
        fan.Revert(prevSpeed);
    }
}
