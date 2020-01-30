using UnityEngine;
using UnityEngine.UI;

public class GUIRemote : MonoBehaviour
{
   
    public Button m_Button;

    Light m_Light;
    LightCommand m_LightCommand;
    LightOffCommand m_LightOffCommand;

    GarageDoor m_Door;
    GarageDoorCommand m_DoorCommand;
    GarageDoorOffCommand m_DoorOffCommand;

    Remote m_Remote;
    
    void Awake(){
        // m_Button.onClick.AddListener(Click);

        m_Light = new Light();
        m_LightCommand = new LightCommand(m_Light);
        m_LightOffCommand = new LightOffCommand(m_Light);
        m_Remote = new Remote();

        m_Remote.SetSlotCommand(0, m_LightCommand, m_LightOffCommand);
        m_Remote.ClickOn(0);
        m_Remote.ClickOff(0);

        m_Door = new GarageDoor();
        m_DoorCommand = new GarageDoorCommand(m_Door);
        m_DoorOffCommand = new GarageDoorOffCommand(m_Door);

        m_Remote.SetSlotCommand(1, m_DoorCommand, m_DoorOffCommand);
        m_Remote.ClickOn(1);
        m_Remote.ClickOff(1);

        Debug.Log(m_Remote.ToString());
    }
}
