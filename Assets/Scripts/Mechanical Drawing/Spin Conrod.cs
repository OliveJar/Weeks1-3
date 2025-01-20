using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinConrod : MonoBehaviour
{
    [SerializeField]
    private Transform Target;
    public float speed = 1.0f;
    [SerializeField]
    private Transform piston;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = new Vector3 (Target.transform.position.x, Target.transform.position.y, 0);
        Vector2 direction = target - transform.position;
        transform.up = direction;

    }
}
