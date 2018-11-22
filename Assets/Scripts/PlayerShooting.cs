using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour {

    public AudioSource tickSource;
    public GameObject BulletPrefab;

    public float fireDelay = 0.25f;
    float cooldownTimer = 0;

     void Start()
    {
        tickSource = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update ()
    {
        cooldownTimer -= Time.deltaTime;

        if(Input.GetKey(KeyCode.Space) && cooldownTimer <= 0 && Time.timeScale != 0)
        {
            Debug.Log("Pew");
            cooldownTimer = fireDelay;

            Instantiate(BulletPrefab, transform.position, transform.rotation);
            tickSource.Play();
        }
	}
}
