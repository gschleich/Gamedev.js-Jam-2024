using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlay : MonoBehaviour
{
    // Add Audio Source component to the object with audio file then add this script
    AudioSource aud;

    void Start()
    {
        aud = GetComponent<AudioSource>();
    }

    public void play_sound()
    {
        aud.Play();
    }

}
