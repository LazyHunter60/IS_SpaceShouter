using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner2 : MonoBehaviour
{
    // public AudioSource på;
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
     //   på = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > nextSpawnTime)
            SpawnEnemy();

        if (Input.GetKey(KeyCode.O))
            Score.scoreValue += 1;
    }


    void SpawnEnemy()
    {
        if (Score.scoreValue >= neededScore)
        {
            Debug.Log("Spawning");
            Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
            Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

            GameObject newEnemy = Instantiate(EnemyToSpawn);
            newEnemy.transform.position = new Vector2(min.x, Random.Range(min.y, max.y));
            maxSpawnTime -= reduceTime;
            if (maxSpawnTime < minSpawnTime)
                maxSpawnTime = minSpawnTime;
        }
        nextSpawnTime += Random.Range(minSpawnTime, maxSpawnTime);
    }
}


