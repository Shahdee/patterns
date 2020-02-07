using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stereo 
{
    public void TurnOn(){
        Debug.Log("stereo on");
    }

    public void TurnOff(){
        Debug.Log("stereo off");
    }

    public void SetCD(){
        Debug.Log("stereo set cd");
    }

    public void SetDVD(){

    }

    public void SetRadio(){
        
    }

    public void SetVolume(int value){
        Debug.Log("SetVolume " + value);
    }
}
