using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerMechanic : MonoBehaviour
{
    public GameObject PowerLine; // Assign the object to enable/disable in the Unity Editor
    public GameObject Spark; // Assign the object to disable in the Unity Editor
    public GameObject OldTower;
    public GameObject NextTriggerTrue;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // Check if the colliding object is tagged as "Player"
        {
            if (PowerLine != null)
            {
                PowerLine.SetActive(true); // Enable the object assigned to PowerLine
            }

            if (Spark != null)
            {
                Spark.SetActive(false); // Disable the object assigned to spark
            }

            if (OldTower != null)
            {
                OldTower.SetActive(false); // Disable the old tower
            }

            if (NextTriggerTrue != null)
            {
                NextTriggerTrue.SetActive(true); // Enable next trigger
            }
        }
    }
}
