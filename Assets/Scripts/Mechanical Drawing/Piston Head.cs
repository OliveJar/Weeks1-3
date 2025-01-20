using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistonHead : MonoBehaviour
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
        //transform.position.x = 0;
        //transform.position = Rotatepoint2.transform.position;
        transform.position = new Vector2(-0.7055448f, (Rotatepoint2.transform.position.y) + 2.444462f);
    }
}
