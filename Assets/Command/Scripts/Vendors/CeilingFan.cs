using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CeilingFan
{
    public static int OFF_SPEED = 0;
    public static int LOW_SPEED = 1;
    public static int MEDIUM_SPEED = 2;
    public static int HIGH_SPEED = 3;
    int speed;

    public CeilingFan(){
        speed = OFF_SPEED;
    }

    public int GetSpeed(){
        return speed;
    }

    public void SetMediumSpeed(){
        speed = MEDIUM_SPEED;

        Debug.Log("SetMediumSpeed");
    }

    public void SetLowSpeed(){
        speed = LOW_SPEED;

        Debug.Log("SetLowSpeed");
    }

    public void SetHighSpeed(){
        speed = HIGH_SPEED;

        Debug.Log("SetHighSpeed");
    }

    public void TurnOff(){
        speed = OFF_SPEED;

        Debug.Log("fan off");
    }

    public void Revert(int prevSpeed){

        Debug.Log("fan revert");

        if (prevSpeed == OFF_SPEED)
            TurnOff();
        
        if (prevSpeed == LOW_SPEED)
            SetLowSpeed();

        if (prevSpeed == MEDIUM_SPEED)
            SetMediumSpeed();

        if (prevSpeed == HIGH_SPEED)
            SetHighSpeed();
    }
}
