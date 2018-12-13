using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMusic : Music
{ 
  
    protected override void Awake()
    {
        GameObject musicDestroyer = GameObject.Find("MusicDestroyer");
        if (musicDestroyer != null)
        {
            Destroy(this.gameObject);
        }

        else if (musicDestroyer == null)
        {
            DontDestroyOnLoad(this.gameObject);
        }
        base.Awake();
    }
}
