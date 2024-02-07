using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonatai5 : MonoBehaviour
{
    public AudioSource SonataSound;

    void Start()
    {
        
        SonataSound.Pause();
    }

    public void SonataEffects()
    {
        if (SonataSound.isPlaying)
        {
          
            SonataSound.Stop();
        }
        else
        {
           
            SonataSound.Play();
        }
    }
    public void OtherButtonEffects()
    {
    }
}