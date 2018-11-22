using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpaceShip : MonoBehaviour {

    public byte Speed;
   
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.D))
            transform.position += new Vector3(Speed * Time.deltaTime, 0, 0);

        if (Input.GetKey(KeyCode.A))
            transform.position -= new Vector3(Speed * Time.deltaTime, 0, 0);

        if (Input.GetKey(KeyCode.W))
            transform.position += new Vector3 (0, Speed * Time.deltaTime, 0);

        if (Input.GetKey(KeyCode.S))
            transform.position -= new Vector3(0, Speed * Time.deltaTime, 0);
	}
}
