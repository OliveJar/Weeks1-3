using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinConrodandPiston : MonoBehaviour
{
    //Declare all variables
    [SerializeField]
    //Gets the location of the crankpin journals (the point of connection of the connecting rod and the crankshaft)
    private Transform Rotatepoint2;

    // Update is called once per frame
    void Update()
    {
        //Makes the connecting rod revolve according to the position of the crankpin journals
        transform.position = Rotatepoint2.transform.position;
    }
}
