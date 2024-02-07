using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeArei7 : MonoBehaviour
{
    public AudioSource WeAreSound;

    void Start()
    {
        
        WeAreSound.Pause();
    }

    public void WeAreEffects()
    {
        if (WeAreSound.isPlaying)
        {
            
            WeAreSound.Stop();
        }
        else
        {
            
            WeAreSound.Play();
        }
    }
    public void OtherButtonEffects()
    {
    }
}