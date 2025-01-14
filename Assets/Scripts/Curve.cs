using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curve : MonoBehaviour
{
    public AnimationCurve curve;
    [Range(0,10)]
    public float t;
    public Vector2 start;
    public Vector2 end;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (t >= 10)
        {
            t = 0;
        }*/


        transform.position = Vector2.Lerp(start, end, curve.Evaluate(t));
    }
}
