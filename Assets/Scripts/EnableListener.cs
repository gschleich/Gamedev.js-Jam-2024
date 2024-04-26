using UnityEngine;

public class EnableListener : MonoBehaviour
{
    public GameObject otherObject; // Reference to the other object
    public Animator animator; // Reference to the animator component
    private BoxCollider2D boxCollider; // Reference to the BoxCollider2D component

    private void Start()
    {
        // Get the BoxCollider2D component attached to this object
        boxCollider = GetComponent<BoxCollider2D>();

    }

    private void Update()
    {
        // Check if the other object is enabled
        if (otherObject.activeSelf && otherObject.GetComponent<MonoBehaviour>().enabled)
        {
            // Trigger the opening animation
            animator.SetTrigger("Open");

            // Disable the BoxCollider2D on this object
            boxCollider.enabled = false;
        }
    }
}