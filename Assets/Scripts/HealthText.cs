using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthText : MonoBehaviour {

    Text healths;
    public static byte healthValue;

	// Use this for initialization
	void Start ()
    {
        healthValue = 4;
        healths = GetComponent<Text>();
	}

    // Update is called once per frame
    void Update()
    {
        healths.text = "Health: " + healthValue;


    } 
}


