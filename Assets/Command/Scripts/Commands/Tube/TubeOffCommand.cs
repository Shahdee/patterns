using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeOffCommand : ICommand
{
    Hottube tube;

    public TubeOffCommand(Hottube tb){
        tube = tb;
    }

    public void Execute(){
        tube.SetOff();
    }

    public void Undo(){
        tube.SetOn();
    }
}
