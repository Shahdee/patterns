using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarageDoorOffCommand : ICommand
{
    GarageDoor m_Door;
    public GarageDoorOffCommand(GarageDoor door){
        m_Door = door;
    }

    public void Execute(){
        m_Door.Down();
    }

    public void Undo(){

        Debug.Log("door undo");

        m_Door.Up();
    }
}
