using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 20;
    // Start is called before the first frame update
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        this.gameObject.transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
        if (this.gameObject.transform.position.x >= 9) {
            Debug.Log("fuck you");
            transform.position = transform.position + new Vector3(-17.9f,0,0);
            this.gameObject.GetComponent<TrailRenderer>().Clear();

        }
        if (this.gameObject.transform.position.x <= -9)
        {
            Debug.Log("fuck you2");
            transform.position = transform.position + new Vector3(17.9f, 0, 0);
            this.gameObject.GetComponent<TrailRenderer>().Clear();

        }
    }

}
