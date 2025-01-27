using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinConrod : MonoBehaviour
{
    //Declare all variables
    [SerializeField]
    //Piston location
    private Transform Target;

    // Update is called once per frame
    void Update()
    {
        //Gets the position of the piston as a vector3 (converts a transform into a vector3)
        Vector3 target = new Vector3 (Target.transform.position.x, Target.transform.position.y, 0);
        //Calculates the angle from the conecting rod to the piston
        Vector2 direction = target - transform.position;
        //Rotates the conecting rod to point in the direction of the piston while spinning
        transform.up = direction;
    }
}
