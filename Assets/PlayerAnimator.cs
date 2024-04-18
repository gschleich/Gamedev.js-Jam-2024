// NO JUMP ADDED
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator animator;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the player is moving
        if (rb.velocity.magnitude > 0.1f)
        {
            // Trigger walk animation
            animator.SetBool("isWalking", true);

            // Flip sprite based on movement direction
            if (rb.velocity.x > 0.1f)
            {
                // Moving right
                spriteRenderer.flipX = false;
            }
            else if (rb.velocity.x < -0.1f)
            {
                // Moving left
                spriteRenderer.flipX = true;
            }
        }
        else
        {
            // Stop walk animation
            animator.SetBool("isWalking", false);
        }
    }
}
