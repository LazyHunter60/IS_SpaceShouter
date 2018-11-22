using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndAnimation : MonoBehaviour {

      void DestroyGameObject()
    {
        Destroy(gameObject);
        Time.timeScale = 1;
    }
}
