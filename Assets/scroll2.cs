using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll2 : MonoBehaviour {

   public float scrollSpeed = -0.05f;
    Renderer rend;
    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
    }
	
	// Update is called once per frame
	void Update () {

        float offset = Time.time * scrollSpeed;
        rend.material.mainTextureOffset = new Vector2(offset, 0);
    }
}
