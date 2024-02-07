using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterN8 : MonoBehaviour
{
    public AudioSource WaterSound;

    // Use this for initialization
    void Start()
    {
        //so it doesn't play automatically
        WaterSound.Pause();
    }

    public void WaterEffects()
    {
        if (WaterSound.isPlaying)
        {
            // If the audio is currently playing, stop it
            WaterSound.Stop();
        }
        else
        {
            // If the audio is not playing, start it
            WaterSound.Play();
        }
    }
    public void OtherButtonEffects()
    {
    }
}