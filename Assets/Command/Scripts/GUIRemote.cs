using UnityEngine;
using UnityEngine.UI;

public class GUIRemote : MonoBehaviour
{
    // client 
    // TODO make it MVC later 

    public Button m_Button;

    Light lights;
    LightCommand lightCommand;
    LightOffCommand lightOffCommand;

    GarageDoor m_Door;
    GarageDoorCommand m_DoorCommand;
    GarageDoorOffCommand m_DoorOffCommand;

    Stereo stereo;
    StereoCommand stereoCommand;
    StereoOffCommand stereoOffCommand;

    CeilingFan fan;
    CeilingFanHighCommand fanHighCommand;
    CeilingFanOffCommand fanOffCommand;
    CeilingFanMediumCommand fanMediumCommand;
    CeilingFanLowCommand fanLowCommand;

    Hottube tube;
    TubeCommand tubeCommand;
    TubeOffCommand tubeOffCommand;
    MacroCommand macroCommand;
    MacroCommand macroOffCommand;

    Remote m_Remote;
    
    void Awake(){
        // m_Button.onClick.AddListener(Click);
        m_Remote = new Remote();

        lights = new Light();
        lightCommand = new LightCommand(lights);
        lightOffCommand = new LightOffCommand(lights);

        int i=0;

        m_Remote.SetSlotCommand(i, (()=>lights.On()), (()=>lights.Off()));
        
        // m_Remote.SetSlotCommand(i, lightCommand, lightOffCommand);
        m_Remote.ClickOn(i);
        // m_Remote.ClickUndo();
        // m_Remote.ClickUndo();
        // m_Remote.ClickUndo();
        m_Remote.ClickOff(i);

        // i++;

        // m_Door = new GarageDoor();
        // m_DoorCommand = new GarageDoorCommand(m_Door);
        // m_DoorOffCommand = new GarageDoorOffCommand(m_Door);

        // m_Remote.SetSlotCommand(i, m_DoorCommand, m_DoorOffCommand);
        // // m_Remote.ClickOn(i);
        // // m_Remote.ClickOff(i);

        // i++;

        // stereo = new Stereo();
        // stereoCommand = new StereoCommand(stereo);
        // stereoOffCommand = new StereoOffCommand(stereo);

        // m_Remote.SetSlotCommand(i, stereoCommand, stereoOffCommand);
        // // m_Remote.ClickOn(i);
        // // m_Remote.ClickOff(i);
        // // m_Remote.ClickUndo();

        // i++;

        // fan = new CeilingFan();

        // fanLowCommand = new CeilingFanLowCommand(fan);
        // fanMediumCommand = new CeilingFanMediumCommand(fan);
        // fanHighCommand = new CeilingFanHighCommand(fan);
        // fanOffCommand = new CeilingFanOffCommand(fan);
        
        // m_Remote.SetSlotCommand(i, fanLowCommand, fanOffCommand);
        // // m_Remote.ClickOn(i);
        // // m_Remote.ClickOff(i);

        // i++;

        // m_Remote.SetSlotCommand(i, fanMediumCommand, fanOffCommand);
        // // m_Remote.ClickOn(i);
        // // m_Remote.ClickUndo();

        // i++;

        // m_Remote.SetSlotCommand(i, fanHighCommand, fanOffCommand);
        // // m_Remote.ClickOn(i);
        // // m_Remote.ClickUndo();

        // i++;

        // tube = new Hottube();
        // tubeCommand = new TubeCommand(tube);
        // tubeOffCommand = new TubeOffCommand(tube);

        // Command[] commandsOn = {lightCommand, stereoCommand, tubeCommand};
        // Command[] commandsOff = {lightOffCommand, stereoOffCommand, tubeOffCommand};
        // macroCommand = new MacroCommand(commandsOn);
        // macroOffCommand = new MacroCommand(commandsOff);

        // m_Remote.SetSlotCommand(i, macroCommand, macroOffCommand);
        // m_Remote.ClickOn(i);
        // m_Remote.ClickUndo();

        // i++;

        Debug.Log(m_Remote.ToString());
    }
}
