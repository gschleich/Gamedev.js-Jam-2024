using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{
    private void Awake()
    {
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("GameMusic");

        if (musicObj.Length > 1)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }

    private void Update()
    {
        // Check if the current scene is "Ending" and destroy the object if it is
        if (SceneManager.GetActiveScene().name == "Ending")
        {
            Destroy(this.gameObject);
        }
    }
}