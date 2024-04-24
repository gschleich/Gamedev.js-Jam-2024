using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScan : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    private Animator anim;
    public float speed;

    private bool movingToB = true;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        anim.SetBool("isRunning", true);
    }

    private void Update()
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

    private void FlipSprite()
    {
        spriteRenderer.flipX = !spriteRenderer.flipX;
    }
}