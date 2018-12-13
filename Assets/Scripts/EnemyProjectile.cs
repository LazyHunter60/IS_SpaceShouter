using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{

    public GameObject EnemyLaserExplosion;
    public float speed = 3f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Get the enemy current position
        Vector2 position = transform.position;

        // Compute the enemy new position
        position = new Vector2(position.x + speed * Time.deltaTime, position.y);

        // Update the enemy position
        transform.position = position;

        // this is the bottom-left point of the screen
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(11.93225f, 0));

        // if the enemy went outside the screen on the bottom, then destroy the enemy.
        if (transform.position.x > 9.93225f)
        {
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.tag == "Player")
        {
            PlayExlposion();
            Destroy(gameObject);
            HealthText.healthValue -= 1;
        }
        else if(collision.collider.gameObject.tag == "Laser")
        {
            PlayExlposion();
            Destroy(gameObject);
        }
    }
    void PlayExlposion()
    {

        GameObject explosion = (GameObject)Instantiate(EnemyLaserExplosion);

        //Set the position of the explosion
        explosion.transform.position = transform.position;
    }
}

