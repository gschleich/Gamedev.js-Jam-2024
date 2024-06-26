using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextSceneOnCollision : MonoBehaviour
{
    // Name of the scene to load
    public string nextSceneName;

    // Check for collision with objects tagged "Player"
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Load the next scene
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
