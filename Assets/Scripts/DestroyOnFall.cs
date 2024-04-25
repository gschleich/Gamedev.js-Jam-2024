using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnFall : MonoBehaviour
{
    public float decreaseThreshold = 1f; // Value by which Y should decrease
    public float destroyDelay = 5f; // Delay before destroying the object

    private float initialY; // Initial Y position

    void Start()
    {
        initialY = transform.position.y; // Record initial Y position
    }

    void Update()
    {
        // Check if Y has decreased by more than the threshold
        if (transform.position.y < initialY - decreaseThreshold)
        {
            // Start the countdown to destroy the object
            destroyDelay -= Time.deltaTime;
            if (destroyDelay <= 0f)
            {
                Destroy(gameObject); // Destroy the object
            }
        }
    }
}