using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDisable : MonoBehaviour
{
    public GameObject RestartCollider;
    private Animator anim;
    public GameObject disableLight;
    public AudioSource collisionSound; // Reference to the AudioSource component

    private bool hasCollided = false; // Variable to keep track of whether collision sound has been played

    private void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("isRunning", true);
        anim.SetBool("isDisabled", false);
        disableLight.SetActive(true);
        RestartCollider.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the colliding object has the "Player" tag
        if (other.gameObject.CompareTag("Player") && anim.GetBool("isRunning") && !hasCollided)
        {
            anim.SetBool("isRunning", false);
            anim.SetBool("isDisabled", true);
            disableLight.SetActive(false);
            RestartCollider.SetActive(false);

            // Play collision sound
            if (collisionSound != null)
                collisionSound.Play();

            hasCollided = true; // Set hasCollided to true to prevent playing sound multiple times

            Invoke("RestartEnemy", 10f); // Restart enemy after 10 seconds
        }
    }

    // Method to restart the enemy after a delay
    private void RestartEnemy()
    {
        anim.SetBool("isRunning", true);
        anim.SetBool("isDisabled", false);
        disableLight.SetActive(true);
        RestartCollider.SetActive(true);

        hasCollided = false; // Reset hasCollided for the next collision
    }
}
