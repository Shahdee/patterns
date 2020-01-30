using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarageDoorOffCommand : Command
{
    GarageDoor m_Door;
    public GarageDoorOffCommand(GarageDoor door){
        m_Door = door;
    }

    public void Execute(){
        m_Door.Down();
    }
}
