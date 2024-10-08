using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ball : MonoBehaviour
{

    private GameObject block;
    private Rigidbody2D rb;
    public LayerMask blockMask;
    [Range(0, 200)]
    [SerializeField] public float thrust;
    [SerializeField] public float currVelocity;
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
        currVelocity = rb.velocity.x+rb.velocity.y;
     if(gameObject.transform.position.y < -5)
        {
            float x = transform.position.x;
            transform.position = new Vector3(x, 0, 0);
        }   
    }
}
