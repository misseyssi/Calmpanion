using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circle : MonoBehaviour
{
    public AudioSource circleSound;

    // Use this for initialization
    void Start()
    {
        //so it doesn't play automatically
        circleSound.Pause();
    }

    public void circleffects()
    {
        if (circleSound.isPlaying)
        {
            // If the audio is currently playing, stop it
            circleSound.Stop();
        }
        else
        {
            // If the audio is not playing, start it
            circleSound.Play();
        }
    }
    public void OtherButtonEffects()
    {
    }
}