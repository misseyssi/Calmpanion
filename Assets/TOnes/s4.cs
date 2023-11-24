using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s4 : MonoBehaviour
{
    public AudioSource wNoiseSound;

    // Use this for initialization
    void Start()
    {
        //so it doesn't play automatically
        wNoiseSound.Pause();
    }

    public void wNoiseffects()
    {
        if (wNoiseSound.isPlaying)
        {
            // If the audio is currently playing, stop it
            wNoiseSound.Stop();
        }
        else
        {
            // If the audio is not playing, start it
            wNoiseSound.Play();
        }
    }
    public void OtherButtonEffects()
    {
    }
}