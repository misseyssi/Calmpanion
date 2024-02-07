using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nature : MonoBehaviour
{
    public AudioSource natureSound;
    
    void Start()
    {
       
        natureSound.Pause();
    }

    public void natureffects()
    {
        if (natureSound.isPlaying)
        {
          
            natureSound.Stop();
        }
        else
        {
            
            natureSound.Play();
        }
    }
    public void OtherButtonEffects()
    {
    }
}
