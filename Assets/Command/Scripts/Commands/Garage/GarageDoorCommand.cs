using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarageDoorCommand : ICommand
{
    GarageDoor m_Door;
    public GarageDoorCommand(GarageDoor door){
        m_Door = door;
    }

    public void Execute(){
        m_Door.Up();
    }

    public void Undo(){
        m_Door.Down();
    }
}
