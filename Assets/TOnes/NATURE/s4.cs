using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class white : MonoBehaviour
{
    public AudioSource whiteSound;

  
    void Start()
    {
      
        whiteSound.Pause();
    }

    public void whiteeffects()
    {
        if (whiteSound.isPlaying)
        {
            whiteSound.Stop();
        }
        else
        {
            
            whiteSound.Play();
        }
    }
    public void OtherButtonEffects()
    {
    }
}