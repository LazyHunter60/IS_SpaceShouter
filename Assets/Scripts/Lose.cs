using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour
{

    public float tid;
    // public GameObject spelare;
    // Use this for initialization
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.Find("Player");
        if (player == null)
        {
            //SceneManager.LoadScene(1);
            //Invoke("LoadLevel", 1.5f);
            StartCoroutine(LoadLevel());
            LoadLevel();
            Time.timeScale = 0.33f;
        }
    }
    IEnumerator LoadLevel()
    {
        yield return new WaitForSecondsRealtime(tid);
        SceneManager.LoadScene(1);
    }
}