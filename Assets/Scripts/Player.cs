using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private GameObject powerUp;
    public int powerUpType;
    public float powerUpTime;
    public float speed = 200;
    public GameObject laser;
    public GameObject laserL;
    public GameObject laserR;

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

        switch (powerUpType)
        {
            case 0:

                break;
            case 1:

                break;
            case 2:

                break;
            case 3:

                break;
            case 4:

                break;
            case 5:

                break;
            case 6:

                break;
            default:
                Debug.Log("cake");
                break;

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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "PowerUp")
        {
            powerUp = collision.gameObject;
            powerUpType = powerUp.GetComponent<PowerUp>().powerUp;

            Destroy(powerUp);
        }
    }

}
