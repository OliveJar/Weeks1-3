using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinCrankShaft : MonoBehaviour
{
    [SerializeField]
    private Transform Rotatepoint;
    [Range(0, -1000)]
    public float rotatespeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Rotatepoint.transform.position, Vector3.back, rotatespeed * Time.deltaTime);
    }
}
