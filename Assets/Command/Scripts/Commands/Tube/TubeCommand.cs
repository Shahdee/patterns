using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeCommand : ICommand
{
    Hottube tube;

    public TubeCommand(Hottube tb){
        tube = tb;
    }

    public void Execute(){
        tube.SetOn();
    }

    public void Undo(){
        tube.SetOff();
    }
}
