using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface State 
{
    void Insert();

    void Eject();

    void Turn();

    void Dispense(); // internal method 
}
