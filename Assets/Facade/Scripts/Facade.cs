using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Facade : MonoBehaviour
{
    Amplifier amplifier = new Amplifier();
    Tuner tuner = new Tuner();
    CDPlayer cdPlayer = new CDPlayer();
    DVDPlayer dvdPlayer = new DVDPlayer();
    Screen screen = new Screen(); 
    Projector projector = new Projector();
    Lights lights = new Lights();
    Popcorn popcorn = new Popcorn();

    HomeTheatreFacade facade;


    // Start is called before the first frame update
    void Start()
    {
        facade = new HomeTheatreFacade(amplifier, tuner, cdPlayer, dvdPlayer, screen, projector, lights, popcorn);

        facade.WatchMovie("beast");
        facade.EndMovie();
        
    }

   
}
