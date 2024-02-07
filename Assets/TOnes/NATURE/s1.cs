using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalmRainButton : MonoBehaviour
{
    public AudioSource CalmRainSound;

  
    void Start()
    {
   
        CalmRainSound.Pause();
    }

    public void CalmRainEffects()
    {
        if (CalmRainSound.isPlaying)
        {
            CalmRainSound.Stop();
        }
        else
        {
            
            CalmRainSound.Play();
        }
    }
    public void OtherButtonEffects()
    {
    }
}
        