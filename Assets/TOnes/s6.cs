using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s6 : MonoBehaviour
{
    public AudioSource dreamlandSound;
    // Use this for initialization
    void Start()
    {
        //so it doesn't play automatically
        dreamlandSound.Pause();
    }

    public void dreamlandffects()
    {
        if (dreamlandSound.isPlaying)
        {
            // If the audio is currently playing, stop it
            dreamlandSound.Stop();
        }
        else
        {
            // If the audio is not playing, start it
            dreamlandSound.Play();
        }
    }
    public void OtherButtonEffects()
    {
    }
}
