using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScan : MonoBehaviour
{
    public GameObject objectToCheck;
    public Transform pointA;
    public Transform pointB;
    public float speed;

    private bool movingToB = true;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (objectToCheck.activeSelf)
        {
            if (movingToB)
            {
                transform.position = Vector2.MoveTowards(transform.position, pointB.position, speed * Time.deltaTime);
                if (Vector2.Distance(transform.position, pointB.position) < 0.1f)
                {
                    FlipSprite();
                    movingToB = false;
                }
            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, pointA.position, speed * Time.deltaTime);
                if (Vector2.Distance(transform.position, pointA.position) < 0.1f)
                {
                    FlipSprite();
                    movingToB = true;
                }
            }
        }
    }

    private void FlipSprite()
    {
        spriteRenderer.flipX = !spriteRenderer.flipX;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the colliding object has the "Player" tag
        if (collision.gameObject.CompareTag("EnemyChecker"))
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