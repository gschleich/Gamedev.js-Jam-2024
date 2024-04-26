using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameButton : MonoBehaviour
{
    public GameObject btn; // Reference object
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
        if (playerInRange && Input.GetKeyDown(KeyCode.E) && !buttonPressed)
        {
            buttonPressed = true; // Mark the button as pressed

            EnableButton(); // Disable the button after it's pressed
        }
    }

    private void EnableButton()
    {
        btn.SetActive(true);
    }
}
