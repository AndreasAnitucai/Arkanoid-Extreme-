using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ball : MonoBehaviour
{


    private Rigidbody2D rb;
    public float thrust;
    public Vector3 currVelocity;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.AddForce(-transform.up * thrust);
        rb.velocity = rb.velocity.normalized * thrust;
    }

    // Update is called once per frame
    void Update()
    {
        currVelocity = rb.velocity;
     if(gameObject.transform.position.y < -5)
        {
            float x = transform.position.x;
            transform.position = new Vector3(x, 0, 0);
        }   
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        {
            if (collision.gameObject.name == "hitboxL")
            {
                rb.velocity = new Vector2(thrust / 200 * -1, thrust / 200);
            }
            if (collision.gameObject.name == "hitboxR")
            {
                rb.velocity = new Vector2(thrust/200, thrust / 200);
            }
            if(collision.gameObject.name == "hitboxM")
            {
                rb.velocity = new Vector2(0, thrust/100);
            }

        }
    }
}
