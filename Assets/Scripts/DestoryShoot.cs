using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryShoot : MonoBehaviour
{
    public GameObject LaserExplosion;
    public AudioSource LaserExplosionSound;

    void Start()
    {
        LaserExplosionSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.tag == "Ship")
        {
            PlayExlposion();
            Destroy(gameObject);
        }
        else if (collision.collider.gameObject.tag == "BigShip")
        {
            PlayExlposion();
            Destroy(gameObject);
        }
       
        else if (collision.collider.gameObject.tag == "EnemyLaser")
        {
            PlayExlposion();
            Destroy(gameObject);
        }

        else if (collision.collider.gameObject.tag == "PlayerLaserDestroyer")
        {
            Destroy(gameObject);
        }

        else if (transform.position.x > 9.93225f || transform.position.x < -9.93225f || transform.position.y > 5.5f || transform.position.y < -5.5f)
        {
            Destroy(gameObject);
        }
    }
    void Update()
    {
        Vector2 position = transform.position;

        if (transform.position.x < -9 && transform.position.x > 9 && transform.position.y < -5.1 && transform.position.y > 5.1)
        {
            Destroy(gameObject);
        }

    }
    void PlayExlposion()
    {

        GameObject explosion = (GameObject)Instantiate(LaserExplosion);

        //Set the position of the explosion
        explosion.transform.position = transform.position;
    }
}
    