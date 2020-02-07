using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StereoOffCommand : ICommand
{
    Stereo stereo;

    public StereoOffCommand(Stereo st){
        stereo = st;
    }
   
   public void Execute(){
       stereo.TurnOff();      
   }

    public void Undo(){

        Debug.Log("stereo undo");

        stereo.TurnOn();
        stereo.SetCD();
        stereo.SetVolume(11);   
    }
}
