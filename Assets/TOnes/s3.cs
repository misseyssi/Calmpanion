using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s3 : MonoBehaviour

{
    public AudioSource waveSound;
    void Start()
    {
        // so it doesn't play automatically
        waveSound.Pause();
    }

    public void waveffects()
    {
        if (waveSound.isPlaying)
        {
            // If the audio is currently playing, stop it
            waveSound.Stop();
        }
        else
        {
            // If the audio is not playing, start it
            waveSound.Play();
        }
    }

   
}

