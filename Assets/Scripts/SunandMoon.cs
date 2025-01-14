using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SunandMoon : MonoBehaviour
{
    [SerializeField]
    private GameObject SunMoon;

    public float rotationSpeed = 0.005f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SunMoon.transform.Rotate(0, 0, rotationSpeed, Space.Self);
    }
}
