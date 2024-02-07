using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuyanI1 : MonoBehaviour
{
    public AudioSource DuyanSound;

    
    void Start()
    {
       
        DuyanSound.Pause();
    }

    public void DuyanEffects()
    {
        if (DuyanSound.isPlaying)
        {
            
            DuyanSound.Stop();
        }
        else
        {
           
            DuyanSound.Play();
        }
    }
    public void OtherButtonEffects()
    {
    }
}