using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinConrodandPiston : MonoBehaviour
{

    [SerializeField]
    private Transform Rotatepoint2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Rotatepoint2.transform.position;
    }
}
