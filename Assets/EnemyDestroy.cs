using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the colliding object has the "Player" tag
        if (collision.gameObject.CompareTag("Player"))
        {
            // Invoke the DestroyEnemy method after 1 second
            Invoke("DestroyEnemy", 1f);
        }
    }

    // Method to destroy the enemy after a delay
    private void DestroyEnemy()
    {
        // Destroy this game object
        Destroy(transform.parent.gameObject);
    }
}
