using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 200;
    // Start is called before the first frame update
    void Update()
    {
        var mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPos.z = 0f;
        float horizontalInput = Input.GetAxis("Mouse X");
        this.gameObject.transform.position = new Vector3(mouseWorldPos.x, -4,0);
        if (mouseWorldPos.x >= 9)
        {
            this.gameObject.transform.position = new Vector3(9, -4, 0);
        }
        if (mouseWorldPos.x <= -9)
        {
            this.gameObject.transform.position = new Vector3(-9, -4, 0);
        }

        //if (this.gameObject.transform.position.x >= 9) {
        //    transform.position = transform.position + new Vector3(-17.9f,0,0);
        //    this.gameObject.GetComponent<TrailRenderer>().Clear();

        //}
        //if (this.gameObject.transform.position.x <= -9)
        //{
        //    transform.position = transform.position + new Vector3(17.9f, 0, 0);
        //    this.gameObject.GetComponent<TrailRenderer>().Clear();

        //}
    }

}
