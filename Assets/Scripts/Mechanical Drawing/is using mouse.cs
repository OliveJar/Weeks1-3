using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isusingmouse : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //Sets the input to controller when mouse is right clicked
        if (Input.GetMouseButtonDown(1))
        {
            SpinCrankShaft.usingMouse = false;
            SpinCrankShaft.usingController = true;
            Cursor.visible = false;
        }
        //and sets the inputs to mouse when mouse is left clicked
        if (Input.GetMouseButtonDown(0))
        {
            SpinCrankShaft.usingMouse = true;
            SpinCrankShaft.usingController = false;
            Cursor.visible = true;
        }
    }
}
