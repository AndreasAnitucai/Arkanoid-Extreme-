using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    [SerializeField] private GameObject powerUp;
    [SerializeField] private int power;
    // Start is called before the first frame update
    void Start()
    {
        powerUp = this.gameObject;
        power = Random.Range(0, 6);
    }
    private void Awake()
    {
        if (power == 0)
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
