using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinCrankShaft : MonoBehaviour
{
    [SerializeField]
    private Transform Rotatepoint;
    public AnimationCurve curve;

    [Range(0, 1000)]
    public float rotatespeed1;

    // Start is called before the first frame update
    void Start()
    {
        rotatespeed1 = 100;
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Rotatepoint.transform.position, Vector3.back, curve.Evaluate(rotatespeed1) * Time.deltaTime);
    }
}
