using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blocks : MonoBehaviour
{

    [Range(0, 5)]
    [SerializeField] public int colour;
    private int powerUpChance;
    private int power;
    void Awake()
    {
        getColour();
    }

    void getDamaged()
    {
        colour--;
        if (colour >= 0)
        {
            getColour();
        }
        else
        {
            powerUpChance = Random.Range(0, 100);
            if(powerUpChance >= 10)
            {
                power = Random.Range(0, 6);
            }
            Destroy(this.gameObject);
        }
    }
    //private void Update()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        getDamaged();

    //    }
    //}

    void getColour()
    {
        if (colour == 0)
        {
            this.gameObject.GetComponentInChildren<SpriteRenderer>().color = Color.green;
        }
        if (colour == 1)
        {
            this.gameObject.GetComponentInChildren<SpriteRenderer>().color = Color.magenta;
        }
        if (colour == 2)
        {
            this.gameObject.GetComponentInChildren<SpriteRenderer>().color = Color.blue;
        }
        if (colour == 3)
        {
            this.gameObject.GetComponentInChildren<SpriteRenderer>().color = Color.yellow;
        }
        if (colour == 4)
        {
            this.gameObject.GetComponentInChildren<SpriteRenderer>().color = Color.red;
        }
        if (colour == 5)
        {
            this.gameObject.GetComponentInChildren<SpriteRenderer>().color = Color.gray;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        {
            if (collision.gameObject.name == "Ball")
            {
                getDamaged();

            }
        }
    }

}
