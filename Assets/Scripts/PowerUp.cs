using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public int powerUp;
    private void Awake()
    {
        Physics.IgnoreLayerCollision(0, 2);
        Physics.IgnoreLayerCollision(4, 5);
        Animator Cake = this.gameObject.GetComponent<Animator>();
        Cake.SetInteger("powerUp", powerUp);
    }
    public void Update()
    {
        if(this.gameObject.transform.position.y < -5)
        {
            Destroy(gameObject);
        }
    }

}
