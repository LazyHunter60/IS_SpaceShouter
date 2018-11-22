using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserSpawner : MonoBehaviour {

    public GameObject LaserToSpawn;

    public Transform firePoint;
    
    private float nextSpawnTime;
    private float timer;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        //if (timer > nextSpawnTime)
           
	}

    void SpawnEnemy()
    {
        Debug.Log("spawning");

        GameObject newLaser = Instantiate(LaserToSpawn);
        

    }
}
