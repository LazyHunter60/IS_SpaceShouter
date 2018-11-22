using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBigShip : MonoBehaviour
{

    public byte health;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.gameObject.tag == "Laser")
        {
            health = health--;

            if(health == 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
