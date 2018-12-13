using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MusicManager : MonoBehaviour
{
    public static MusicManager manager;

    private void Awake()
    {
        if(manager == null)
        {
            manager = this;
        }
        else
        {
            if(manager != this)
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnLevelWasLoaded(int level)
    {
        if (level == 0)
        {
            Destroy(gameObject);
        }
        else if (level != 0)
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
