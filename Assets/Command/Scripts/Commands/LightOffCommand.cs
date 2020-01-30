using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOffCommand : Command
{
    Light m_Light;

    public LightOffCommand(Light light){
        m_Light = light;
    }

    public void Execute(){
        m_Light.Off();
    }
}
