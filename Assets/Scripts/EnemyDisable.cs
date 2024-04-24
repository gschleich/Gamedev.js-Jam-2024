using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDisable : MonoBehaviour
{
    private Animator anim;
    public GameObject disableLight;

    private void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("isRunning", true);
        anim.SetBool("isDisabled", false);
        disableLight.SetActive(true);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the colliding object has the "Player" tag
        if (collision.gameObject.CompareTag("Player") && anim.GetBool("isRunning"))
        {

            anim.SetBool("isRunning", false);
            anim.SetBool("isDisabled", true);
            disableLight.SetActive(false);

            Invoke("Start", 10f); // The off animation was 10 seconds.. maybe change to a var later
            //Invoke("DestroyEnemy", 10f);
        }
    }

    // Method to destroy the enemy after a delay
    private void DestroyEnemy()
    {
        // Destroy this game object
        Destroy(transform.parent.gameObject);
    }
}
