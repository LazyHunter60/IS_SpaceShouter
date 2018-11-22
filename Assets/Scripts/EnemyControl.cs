using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : DestroyPlayer {

    public byte speed;
	// Use this for initialization
	void Start ()
    {       
        speed = 2;
	}
	
	// Update is called once per frame
	void Update ()
    {
        // Get the enemy current position
        Vector2 position = transform.position;

        // Compute the enemy new position
        position = new Vector2(position.x + speed * Time.deltaTime, position.y );

        // Update the enemy position
        transform.position = position;

        // this is the bottom-left point of the screen
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(11.93225f, 0));

        // if the enemy went outside the screen on the bottom, then destroy the enemy.
        if(transform.position.x > 9.93225f)
        {
            Destroy(gameObject);
        }

	}
    
}
