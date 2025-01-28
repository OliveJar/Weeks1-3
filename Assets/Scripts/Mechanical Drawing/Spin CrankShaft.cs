using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinCrankShaft : MonoBehaviour
{
    // Declare All Variables
    [SerializeField]
    //The center of rotation for the crankshaft (also its position)
    private Transform Rotatepoint;
    //Accleration curve
    public AnimationCurve curve;
    //Interpolation value for the basic lerp
    private float t = 0.0f;
    //Interpolation value for the boosted lerp
    private float t2 = 0.0f;
    [Header("Rotation Controls")]
    //The lerp time value
    public float response = 0.5f;
    //The rotation speed of the crankshaft
    public float rotatespeed1;
    [Header("Controls")]
    //Mouse input boolean
    public static bool usingMouse = true;
    //Controller input boolean
    public static bool usingController = false;

    // Start is called before the first frame update
    void Start()
    {
        rotatespeed1 = 100;
    }

    // Update is called once per frame
    void Update()
    {
        //Increases the interpolation value for the basic lerp
        t += response * Time.deltaTime;

        //Resets the interpolation value for the basic lerp
        if (t > 1.0f)
        {
            t = rotatespeed1 *0.01f;
        }


        //Increases the interpolation value for the boosted lerp
        t2 += response * Time.deltaTime;

        //Resets the interpolation value for the boosted lerp
        if (t2 > 1.0f)
        {
            t2 = rotatespeed1 *0.0005f;
        }

        //--------------------------------------------CONTROLS--------------------------------------------\\

        

        //If the mouse is being used use mouse inputs
        if(usingMouse)
        {
            //Track the mouse position according to the position of the camera
            Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //Lerp the mouse y postiton using the basic interpolation value and change the rotation speed accordingly
            rotatespeed1 = Mathf.Lerp(1, (Mathf.Clamp(((mouse.y)+2)*250, 1, 1000)), t);

            //Checks to see if the mouse left click is pressed to add NO2 to the engine (boost)
            if(Input.GetMouseButton(0))
            {
                //If mouse is left clicked then increase the rotation speed using the boosted interpolation value
                rotatespeed1 = Mathf.Lerp(1000, 2000, t2);
            }
        }

        //If a controller is being used then use controller inputs
        if (usingController)
        {
            //Lerp the controller's right trigger input and change the rotation speed accordingly
            rotatespeed1 = Mathf.Lerp(1, (Mathf.Clamp((Input.GetAxis("Mouse Y") * 10000), 1, 1000)), t);

            //Checks to see if the a button is pressed (on xbox controller) to add NO2 to the engine (boost)
            if(Input.GetButton("Fire1") && (Input.GetAxis("Mouse Y") >= 0.1))
            {
                //If the a button is clicked then increase the rotation speed using the boosted interpolation value
                rotatespeed1 = Mathf.Lerp(1000, 2000, t2);
            }
        }
        //Rotates the crankchaft to the rotation speed variable acording to the animation curve
        transform.RotateAround(Rotatepoint.transform.position, Vector3.back, curve.Evaluate(rotatespeed1) * Time.deltaTime);
    }
}
