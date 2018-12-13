using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Music : MonoBehaviour {

    public bool checkInGame;

    public AudioSource audioSource; //ljudkällan (vart ljudet spelas ifrån)

    public AudioClip songOne; //låt 1
    public AudioClip songTwo; //låt 2

    private void Update()
    {
        if (checkInGame == true)
        {
            audioSource.PlayOneShot(songTwo);
            //spela min låt
        }

        if (checkInGame == false)
        {
            audioSource.PlayOneShot(songOne);
        }
    }

    // Use this for initialization
    protected virtual void Awake()
    {
       // GameObject musicDestroyer = GameObject.Find("MusicDestroyer");
       
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");

        if (objs.Length > 1)
            Destroy(this.gameObject);

        DontDestroyOnLoad(this.gameObject);
        }      
    }    

