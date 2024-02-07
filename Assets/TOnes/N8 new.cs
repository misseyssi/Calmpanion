using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nature8 : MonoBehaviour
{
    public AudioSource water8Sound;
    // Use this for initialization
    void Start()
    {
        //so it doesn't play automatically
        water8Sound.Pause();
    }

    public void natureeffects8()
    {
        if (water8Sound.isPlaying)
        {
            // If the audio is currently playing, stop it
            water8Sound.Stop();
        }
        else
        {
            // If the audio is not playing, start it
            water8Sound.Play();
        }
    }
    public void OtherButtonEffects()
    {
    }
}
