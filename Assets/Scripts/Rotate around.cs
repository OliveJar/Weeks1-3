using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotatearound : MonoBehaviour
{
    [SerializeField]
    private Transform Rotatepoint;
    public float rotatespeed = 10;
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
