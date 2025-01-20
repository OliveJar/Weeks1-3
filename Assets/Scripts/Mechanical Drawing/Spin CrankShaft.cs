using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinCrankShaft : MonoBehaviour
{
    [SerializeField]
    private Transform Rotatepoint;
    public AnimationCurve curve;

    //[Range(0, 1000)]
    public float rotatespeed1;
    public bool usingMouse;
    public bool usingController;

    // Start is called before the first frame update
    void Start()
    {
        rotatespeed1 = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if(usingMouse)
        {
            usingController = false;

            Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            rotatespeed1 = Mathf.Clamp(((mouse.y)+2)*250, 0, 1000);

            if(Input.GetButton("Fire1"))
            {
                rotatespeed1 = 2000;
            }
        }
        if (usingController)
        {
            usingMouse = false;
            rotatespeed1 = Mathf.Clamp((Input.GetAxis("Mouse Y") * 10000), 0, 1000);
            if(Input.GetButton("Fire1") && (Input.GetAxis("Mouse Y") >= 0.1))
            {
                rotatespeed1 = 2000;
            }
        }
        transform.RotateAround(Rotatepoint.transform.position, Vector3.back, curve.Evaluate(rotatespeed1) * Time.deltaTime);
    }
}
