using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStayInside : MonoBehaviour {

	
	void Update ()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -8.43f, 8.43f),
        Mathf.Clamp(transform.position.y, -4.36f, 4.36f), transform.position.z);
	}
}
