using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circlei4 : MonoBehaviour
{
    public AudioSource circleSound;

   
    void Start()
    {
       
        circleSound.Pause();
    }

    public void circleEffects()
    {
        if (circleSound.isPlaying)
        {
          
            circleSound.Stop();
        }
        else
        {
            
            circleSound.Play();
        }
    }
    public void OtherButtonEffects()
    {
    }
}