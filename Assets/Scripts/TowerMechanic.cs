using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerMechanic : MonoBehaviour
{
    public GameObject PowerLine; // Assign the object to enable/disable in the Unity Editor
    public GameObject Spark; // Assign the object to disable in the Unity Editor
    public GameObject OldTower;
    public GameObject NextTriggerTrue;
    public AudioClip collisionSound; // Assign the audio clip in the Unity Editor

    private AudioSource audioSource; // Reference to the AudioSource component
    private bool hasCollided = false; // Flag to track if collision has occurred

    private void Start()
    {
        // Get the AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!hasCollided && collision.CompareTag("Player")) // Check if the colliding object is tagged as "Player" and collision hasn't occurred before
        {
            if (PowerLine != null)
            {
                PowerLine.SetActive(true); // Enable the object assigned to PowerLine
            }

            if (Spark != null)
            {
                Spark.SetActive(false); // Disable the object assigned to spark
            }

            if (OldTower != null)
            {
                OldTower.SetActive(false); // Disable the old tower
            }

            if (NextTriggerTrue != null)
            {
                NextTriggerTrue.SetActive(true); // Enable next trigger
            }

            // Check if audio clip is assigned and AudioSource component exists
            if (collisionSound != null && audioSource != null)
            {
                // Play the collision sound
                audioSource.PlayOneShot(collisionSound);
            }

            hasCollided = true; // Set the flag to true after the first collision
        }
    }
}
