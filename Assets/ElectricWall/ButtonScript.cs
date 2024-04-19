using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject blueWall; // Reference to the blue wall object
    private bool playerInRange; // Flag to track if player is in range
    private bool buttonPressed; // Flag to track if button is pressed

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerInRange = true; // Player is in range
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerInRange = false; // Player is no longer in range
        }
    }

    private void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            buttonPressed = !buttonPressed; // Toggle button press state

            if (buttonPressed)
            {
                DisableBlueWall();
            }
            else
            {
                EnableBlueWall();
            }
        }
    }

    private void DisableBlueWall()
    {
        blueWall.SetActive(false); // Disable the blue wall object
    }

    private void EnableBlueWall()
    {
        blueWall.SetActive(true); // Enable the blue wall object
    }
}
