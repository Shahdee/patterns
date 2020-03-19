using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeTheatreFacade 
{
    Amplifier amplifier;
    Tuner tuner;
    CDPlayer cdPlayer;
    DVDPlayer dvdPlayer;
    Screen screen;
    Projector projector;
    Lights lights;
    Popcorn popcorn;

    public HomeTheatreFacade(
                            Amplifier a,
                            Tuner t,
                            CDPlayer cdpl,
                            DVDPlayer dvdpl,
                            Screen scr,
                            Projector pr,
                            Lights lg,
                            Popcorn pc){
        amplifier = a;
        tuner = t;
        cdPlayer = cdpl;
        dvdPlayer = dvdpl;
        screen = scr; 
        projector = pr; 
        lights = lg; 
        popcorn = pc;
    }

    public void WatchMovie(string movie){
        popcorn.On();
        popcorn.Pop();
        lights.Dim(10);
        screen.Down();
        projector.On();
        projector.WideScreenOn();
        amplifier.On();
        amplifier.SetDVD(dvdPlayer);
        amplifier.SetSurroundSound();
        amplifier.SetVolume(5);
        dvdPlayer.On();
        dvdPlayer.Play(movie);
    }

    public void EndMovie(){
        popcorn.Off();
        lights.On();
        screen.Up();
        projector.Off();
        amplifier.Off();
        dvdPlayer.Stop();
        dvdPlayer.Eject();
        dvdPlayer.Off();
    }
}
