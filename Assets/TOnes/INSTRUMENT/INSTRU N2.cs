using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stari2 : MonoBehaviour
{
    public AudioSource starSound;

    void Start()
    {
        
        starSound.Pause();
    }

    public void starEffects()
    {
        if (starSound.isPlaying)
        {
            
            starSound.Stop();
        }
        else
        {
          
            starSound.Play();
        }
    }
    public void OtherButtonEffects()
    {
    }
}