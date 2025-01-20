using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinCrankShaft : MonoBehaviour
{
    [SerializeField]
    private Transform Rotatepoint;
    public AnimationCurve curve;
    private float t = 0.0f;
    private float t2 = 0.0f;
    public float response = 0.5f;

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
        t += response * Time.deltaTime;

        if (t > 1.0f)
        {
            t = rotatespeed1 *0.01f;
        }

        t2 += response * Time.deltaTime;

        if (t2 > 1.0f)
        {
            t2 = rotatespeed1 *0.0005f;
        }

        if(usingMouse)
        {
            usingController = false;

            Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            rotatespeed1 = Mathf.Lerp(1, (Mathf.Clamp(((mouse.y)+2)*250, 1, 1000)), t);

            if(Input.GetMouseButton(0))
            {
                rotatespeed1 = Mathf.Lerp(1000, 2000, t2);
            }
        }

        if (usingController)
        {
            usingMouse = false;
            rotatespeed1 = Mathf.Lerp(1, (Mathf.Clamp((Input.GetAxis("Mouse Y") * 10000), 1, 1000)), t);

            if(Input.GetButton("Fire1") && (Input.GetAxis("Mouse Y") >= 0.1))
            {
                rotatespeed1 = Mathf.Lerp(1000, 2000, t2);
            }
        }
        transform.RotateAround(Rotatepoint.transform.position, Vector3.back, curve.Evaluate(rotatespeed1) * Time.deltaTime);
    }
}
