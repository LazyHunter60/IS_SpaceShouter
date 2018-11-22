using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : DestroyPlayer
{


    Text hälsa;

    public static int scoreValue = 0;
    // Use this for initialization
    void Start()
    {
        scoreValue = 0;
        hälsa = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        hälsa.text = "Health: " + scoreValue;
    }
}