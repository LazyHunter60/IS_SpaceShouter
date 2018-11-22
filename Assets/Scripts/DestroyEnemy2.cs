using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy2 : MonoBehaviour {

    public int health;
	// Update is called once per frame
	void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.gameObject.tag == "Laser")
        {
            health = health - 1;
        }
        else if (health == 0)
        {
            Destroy(gameObject);
        }
    }


    }

