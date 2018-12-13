using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
   
    public GameObject EnemyToSpawn;

    public float maxSpawnTime = 2f;
    public float minSpawnTime = 0.5f;

    public float neededScore = 0f;
    public float reduceTime = 0.1f;
    private float nextSpawnTime;


    private float timer;
    // Use this for initialization
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > nextSpawnTime)
            SpawnEnemy();

    }


    void SpawnEnemy()
    {
        if (Score.scoreValue >= neededScore)
        {
            Debug.Log("Spawning");
            Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(-0.05f, 0.1f));
            Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 0.9f));

            GameObject newEnemy = Instantiate(EnemyToSpawn);
            newEnemy.transform.position = new Vector2(min.x, Random.Range(min.y, max.y));
            maxSpawnTime -= reduceTime;
            if (maxSpawnTime < minSpawnTime)
                maxSpawnTime = minSpawnTime;
        }
        nextSpawnTime += Random.Range(minSpawnTime, maxSpawnTime);
    }
}


