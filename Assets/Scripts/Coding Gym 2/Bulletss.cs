using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletss : MonoBehaviour
{
    public float bulletSpeed = 10;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       /* Vector3 mouse2 = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouse2.z = 0;
        Vector2 direction = mouse2;*/

        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.right * bulletSpeed;
    }
}
