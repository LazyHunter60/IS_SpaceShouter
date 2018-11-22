using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YourScore : Score {

    Text poäng;
	// Use this for initialization
	void Start ()
    {
        poäng = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        poäng.text = "Your score: " + scoreValue;
	}
}
