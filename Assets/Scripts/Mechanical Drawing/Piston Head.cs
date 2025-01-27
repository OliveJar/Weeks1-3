using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistonHead : MonoBehaviour
{
    //Declare all variables
    [SerializeField]
    //Gets the location of the crankpin journals (the point of connection of the connecting rod and the crankshaft)
    private Transform Rotatepoint2;
    public float pistonX;

    // Update is called once per frame
    void Update()
    {
        //Makes the piston move up and down according to the position of the crankpin journals
        transform.position = new Vector2(pistonX, (Rotatepoint2.transform.position.y) + 2.444462f);
    }
}
