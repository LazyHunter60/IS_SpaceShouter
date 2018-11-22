using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour {

    [Range(0f, 5f)]
    public float ScrollScale = 5;
    private Material mat;
	// Use this for initialization
	void Start ()
    {
        mat = GetComponent<Renderer>().material;
	}
	
	// Update is called once per frame
	void Update ()
    {
        mat.mainTextureOffset = new Vector2(Time.time * ScrollScale, 0);
	}
}
