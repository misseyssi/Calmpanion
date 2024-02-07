using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterN8 : MonoBehaviour
{
    public AudioSource WaterSound;

   
    void Start()
    {
        
        WaterSound.Pause();
    }

    public void WaterEffects()
    {
        if (WaterSound.isPlaying)
        {
            
            WaterSound.Stop();
        }
        else
        {
            
            WaterSound.Play();
        }
    }
    public void OtherButtonEffects()
    {
    }
}