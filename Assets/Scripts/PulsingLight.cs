using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 // This is needed for Light2D

public class PulsingLight : MonoBehaviour
{
    public float minIntensity = 1f; // Minimum intensity of the light
    public float maxIntensity = 2f; // Maximum intensity of the light
    public float pulseDuration = 2f; // Duration of each pulse

    private float currentIntensity; // Current intensity of the light
    private bool increasingIntensity = true; // Flag to track if intensity is increasing or decreasing
    private float timeSinceLastPulse = 0f; // Time elapsed since the last pulse

    private UnityEngine.Rendering.Universal.Light2D light2D; // Reference to the Light2D component

    void Start()
    {
        light2D = GetComponent<UnityEngine.Rendering.Universal.Light2D>();
        currentIntensity = minIntensity;
        light2D.intensity = currentIntensity;
    }

    void Update()
    {
        // Update the time elapsed since the last pulse
        timeSinceLastPulse += Time.deltaTime;

        // If it's time for a pulse, change intensity accordingly
        if (timeSinceLastPulse >= pulseDuration)
        {
            // Toggle the flag to switch between increasing and decreasing intensity
            increasingIntensity = !increasingIntensity;

            // Reset the time since last pulse
            timeSinceLastPulse = 0f;
        }

        // Update the intensity based on the flag
        if (increasingIntensity)
        {
            currentIntensity = Mathf.Lerp(minIntensity, maxIntensity, timeSinceLastPulse / pulseDuration);
        }
        else
        {
            currentIntensity = Mathf.Lerp(maxIntensity, minIntensity, timeSinceLastPulse / pulseDuration);
        }

        // Update the intensity of the light
        light2D.intensity = currentIntensity;
    }
}
