using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class room3 : MonoBehaviour
{
    private bool laser1 = false;
    private bool laser2 = false;
    private bool doorOpen = false;

    public void SetLaser() { 
        if (laser1 == false) { laser1 = true; } 
        else { laser2 = true; }
    }

    private void Update()
    {
        if (laser1 && laser2 && !doorOpen)
        {
            doorOpen = true;
            //Game win
        }
    }
}
