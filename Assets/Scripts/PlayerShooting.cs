using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour {

    public AudioSource tickSource; //ljudkällan (vart ljudet spelas ifrån)
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

        if(Input.GetMouseButtonDown(0) && cooldownTimer <= 0 && Time.timeScale != 0)
        {
            Debug.Log("Pew");
            cooldownTimer = fireDelay;

            Instantiate(BulletPrefab, transform.position, transform.rotation);
            tickSource.Play();
        }
	}
}
