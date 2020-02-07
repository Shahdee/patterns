using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StereoCommand : ICommand
{
    Stereo stereo;

    public StereoCommand(Stereo st){
        stereo = st;
    }
   
   public void Execute(){
       stereo.TurnOn();
       stereo.SetCD();
       stereo.SetVolume(11);
   }

    public void Undo(){
        stereo.TurnOff();
    }
}
