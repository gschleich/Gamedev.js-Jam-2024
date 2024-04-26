using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToFirstScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ReturnToFirstSceneAfterDelay(15f));
    }

    IEnumerator ReturnToFirstSceneAfterDelay(float delay)
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(delay);

        // Load the first scene by its build index (assuming it's the first scene added to the build settings)
        SceneManager.LoadScene(0);
    }
}
