using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour {

	public void changeToScene(int changeTheScene)
    {
        SceneManager.LoadScene(changeTheScene);
        Time.timeScale = 1;
    }
}
