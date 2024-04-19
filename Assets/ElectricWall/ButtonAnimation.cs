using UnityEngine;

public class ButtonAnimation : MonoBehaviour
{
    public Animator buttonAnimator; // Reference to the Animator component for the button
    public string playerTag = "Player"; // Tag of the player object
    public string interactKey = "E"; // Key to press for interaction

    private bool isPlayerColliding = false; // Flag to track if player is colliding with the button

    void Update()
    {
        // Check if player is colliding with the button and if the interact key is pressed
        if (isPlayerColliding && Input.GetKeyDown(interactKey))
        {
            // Trigger the ButtonPress animation
            buttonAnimator.SetTrigger("ButtonPress");
        }
    }

    // Called when a collider enters the trigger area of the button
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(playerTag))
        {
            // Player is colliding with the button
            isPlayerColliding = true;
        }
    }

    // Called when a collider exits the trigger area of the button
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag(playerTag))
        {
            // Player is no longer colliding with the button
            isPlayerColliding = false;
        }
    }
}
