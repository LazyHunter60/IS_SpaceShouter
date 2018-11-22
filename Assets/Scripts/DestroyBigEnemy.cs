using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBigEnemy : DestroyEnemy
{
    public byte health;

    public GameObject ExplosionGO;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.tag == "Laser")
        {
            health--;
            
            if(health == 0)
            {
                PlayExlposion();

                Destroy(gameObject);
                Score.scoreValue += 3;
            }            
            
        }
        else if (collision.collider.gameObject.tag == "Player")
        {
            PlayExlposion();
            Destroy(gameObject);
        }
    }
    
    void PlayExlposion()
    {
        GameObject explosion = (GameObject)Instantiate(ExplosionGO);

        //Set the position of the explosion
        explosion.transform.position = transform.position;
    }
}