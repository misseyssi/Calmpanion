using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdNature : MonoBehaviour
{
    public AudioSource BirdNatureSound;

  
    void Start()
    {
       
    }

    public void BirdNatureffects()
    {
        if (BirdNatureSound.isPlaying)
        {
           
            BirdNatureSound.Stop();
        }
        else
        {
          
            BirdNatureSound.Play();
        }
    }
    public void OtherButtonEffects()
    {
    }
}
