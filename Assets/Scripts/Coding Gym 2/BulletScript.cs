using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public GameObject Bullet;
    public static Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject newBullet = Instantiate(Bullet, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
            newBullet.transform.right = transform.up;
            Destroy(newBullet, 1.0f);
        }
        
    }
}
