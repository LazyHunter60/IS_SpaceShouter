﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealScrollingBackground : MonoBehaviour {

    public float scalar = 1f;
    private Material mat;
	// Use this for initialization
	void Start ()
    {
        mat = GetComponent<Renderer>().material;
	}
	
	// Update is called once per frame
	void Update ()
    {
        mat.SetTextureOffset("_MainTex", new Vector2(Time.time * scalar, 0));
	}
}
