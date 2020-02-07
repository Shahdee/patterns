using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hottube 
{
    int currTemp = 0;

    public void SetOn(){
        Debug.Log("hottube on ");
        SetTemperature(114);
    }

    public void SetOff(){
        Debug.Log("hottube off ");
        SetTemperature(0);
    }

    void SetTemperature(int tmp){
        currTemp = tmp;
    }
}
