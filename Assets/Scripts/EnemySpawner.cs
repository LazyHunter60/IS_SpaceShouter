using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public GameObject EnemyGO;
    

    float maxSpawnRateInSeconds;
	// Use this for initialization
	void Start ()
    {
        Invoke("SpawnEnemy", maxSpawnRateInSeconds);
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.O))
            SpawnEnemy();   
	}


    void SpawnEnemy()
    {
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));

        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        GameObject anEnemy = (GameObject)Instantiate(EnemyGO);
        anEnemy.transform.position = new Vector2(min.x , Random.Range(min.y, max.y));

      

        ScheduleNextEnemySpawn();
    }

    void ScheduleNextEnemySpawn()
    {
        float spawnInSeconds;

        if(Score.scoreValue < 15)
        {

        if (maxSpawnRateInSeconds > 2f)
        {
            spawnInSeconds = Random.Range(2f, maxSpawnRateInSeconds);
        }
        else

            spawnInSeconds = 2f;

        Invoke("SpawnEnemy", spawnInSeconds);     
    }
        else
        {
            if (maxSpawnRateInSeconds > 1f)
            {
                spawnInSeconds = Random.Range(1f, maxSpawnRateInSeconds);
            }
            else

                spawnInSeconds = 1f;

            Invoke("SpawnEnemy", spawnInSeconds);
        }
    }
}
