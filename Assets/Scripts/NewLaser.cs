using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewLaser : MonoBehaviour
{

    //public float playerRange;

    //public GameObject enemyStar;

    public Transform launchPoint;

    public byte waitBetweenShots = 180;

    private byte shotCounter;

    public GameObject projectile;

    // Use this for initialization
    void Start()
    {
        shotCounter = waitBetweenShots;
    }

    // Update is called once per frame
    void Update()
    {
        shotCounter += 1;
        if (shotCounter > 255)
        {
            shotCounter = 0;
        }
    
        if (shotCounter % waitBetweenShots == 0 && Time.timeScale != 0)
        {
            GameObject shotsFired = Instantiate(projectile);
            shotsFired.transform.position = transform.position;
            // Debug.DrawLine(new Vector3(transform));

            }
        }

    }

