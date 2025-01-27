using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Tank : MonoBehaviour
{
    [SerializeField]
    private float TankSpeed = 2;
    public Rigidbody Trb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouse.z = 0;
        Vector2 direction = mouse - transform.position;
        transform.up = direction;

        Trb.velocity = transform.up * Input.GetAxis("Vertical") * TankSpeed;
    }
}
