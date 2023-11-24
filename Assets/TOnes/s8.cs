using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontWannaCry : MonoBehaviour
{
    public AudioSource dWCSound;

    // Use this for initialization
    void Start()
    {
        //so it doesn't play automatically
        dWCSound.Pause();
    }

    public void dWCEffects()
    {
        if (dWCSound.isPlaying)
        {
            // If the audio is currently playing, stop it
            dWCSound.Stop();
        }
        else
        {
            // If the audio is not playing, start it
            dWCSound.Play();
        }
    }
    public void OtherButtonEffects()
    {
    }
}