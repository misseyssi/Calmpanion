using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    public AudioSource StarSound;
    // Use this for initialization
    void Start()
    {
        //so it doesn't play automatically
        StarSound.Pause();
    }

    public void stareffects()
    {
        if (StarSound.isPlaying)
        {
            // If the audio is currently playing, stop it
            StarSound.Stop();
        }
        else
        {
            // If the audio is not playing, start it
            StarSound.Play();
        }
    }
    public void OtherButtonEffects()
    {
    }
}
