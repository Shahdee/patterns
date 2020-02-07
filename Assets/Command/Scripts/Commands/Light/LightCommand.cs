using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCommand : ICommand
{
    Light m_Light;

    public LightCommand(Light light){
        m_Light = light;
    }

    public void Execute(){
        m_Light.On();
    }

    public void Undo(){
        m_Light.Off();
    }
}
