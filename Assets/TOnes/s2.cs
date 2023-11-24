using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nature : MonoBehaviour
{
    public AudioSource natureSound;
    // Use this for initialization
    void Start()
    {
        //so it doesn't play automatically
        natureSound.Pause();
    }

    public void natureeffects()
    {
        if (natureSound.isPlaying)
        {
            // If the audio is currently playing, stop it
            natureSound.Stop();
        }
        else
        {
            // If the audio is not playing, start it
            natureSound.Play();
        }
    }
    public void OtherButtonEffects()
    {
    }
}
