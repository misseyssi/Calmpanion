using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yawn : MonoBehaviour

{
    public AudioSource yawnSound;
    void Start()
    {
        // so it doesn't play automatically
        yawnSound.Pause();
    }

    public void yawnffects()
    {
        if (yawnSound.isPlaying)
        {
            // If the audio is currently playing, stop it
            yawnSound.Stop();
        }
        else
        {
            // If the audio is not playing, start it
            yawnSound.Play();
        }
    }

   
}

