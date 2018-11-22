using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DestroyPlayer : MonoBehaviour
{
    public byte health;
    public float tid = 2;
    private SpriteRenderer ur;
    public GameObject ExplosionGO2;

    private void Start()
    {
        ur = GetComponent<SpriteRenderer>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.tag == "Ship")
        {
            health -= 2;
            HealthText.healthValue -= 2;
        }


        if (collision.collider.gameObject.tag == "BigShip")
        {
            PlayExlposion();
            Destroy(gameObject);
            HealthText.healthValue = 0;
        }
        if (collision.collider.gameObject.tag == "EnemyLaser")
        {
            health--;
        }
         if (health == 0)
            {
            PlayExlposion();
                Destroy(gameObject);
            }
         else if(health > 4)
        {
            PlayExlposion();
            Destroy(gameObject);
            HealthText.healthValue = 0;
        }
        }
    void PlayExlposion()
    {

        GameObject explosion = (GameObject)Instantiate(ExplosionGO2);

        //Set the position of the explosion
        explosion.transform.position = transform.position;
    }
}




   