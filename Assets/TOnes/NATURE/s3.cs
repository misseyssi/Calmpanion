using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wave : MonoBehaviour

{
    public AudioSource waveSound;
    void Start()
    {
        
        waveSound.Pause();
    }

    public void waveffects()
    {
        if (waveSound.isPlaying)
        {
          
            waveSound.Stop();
        }
        else
        {
            
            waveSound.Play();
        }
    }

   
}

