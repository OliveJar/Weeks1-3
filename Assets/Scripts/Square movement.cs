using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Squaremovement : MonoBehaviour
{
    public Rigidbody2D rb;
    private bool isGrounded = false;
    public float floatHeight;
    public float playerHeight;
    public float jumpForce;
    public float velocityX;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up);
        if (hit)
        {
            float distance = Mathf.Abs(hit.point.y - transform.position.y);
            float heightError = floatHeight - distance;

            if (distance <= (playerHeight / 2))
            {
                isGrounded = true;
            }
        }
        else
        {
            isGrounded = false;
        }
        if (Input.GetKeyDown(KeyCode.W) && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }


        if(Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector2.left, ForceMode2D.Force);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector2.right, ForceMode2D.Force);
        }

        rb.velocity = new Vector2 (Mathf.Clamp(rb.velocity.x, -10, 10), rb.velocity.y);
        
    }
}
