using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public float bounceHeight = 1.0f; // Intensity of the bounce
    public float bounceSpeed = 1.0f; // Speed of the bounce

    private Vector3 startPos;
    private float startTime;

    void Start()
    {
        startPos = transform.position;
        startTime = Time.time;
    }

    void Update()
    {
        // Calculate how far along the bounce animation we are
        float t = (Time.time - startTime) * bounceSpeed;

        // Calculate the new position using a sine wave to simulate bouncing
        Vector3 newPosition = startPos + Vector3.up * Mathf.Sin(t) * bounceHeight;

        // Apply the new position to the object
        transform.position = newPosition;
    }
}
