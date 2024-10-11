using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallBlock : MonoBehaviour
{

    public Color Cake;
    // Start is called before the first frame update
    void Awake()
    {
        this.gameObject.GetComponent<SpriteRenderer>().color = Cake;
    }

}
