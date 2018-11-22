using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour {

    public AudioSource på;
    public GameObject ExplosionGO;

     void Start()
    {
        på = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.tag == "Laser")
        {
            Destroy(gameObject);
            PlayExlposion();
            Score.scoreValue += 1;
        }
        else if (collision.collider.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            PlayExlposion();

        }
    }
        // Function to instantiate an explosion
        void PlayExlposion()
        {
        
            GameObject explosion = (GameObject)Instantiate(ExplosionGO);
        
        //Set the position of the explosion
        explosion.transform.position = transform.position;

            på.Play();
        
        }
    }


