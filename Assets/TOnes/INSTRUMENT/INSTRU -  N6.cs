using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dreami6 : MonoBehaviour
{
    public AudioSource dreamsound;

  
    void Start()
    {
       
        dreamsound.Pause();
    }

    public void DreamEffects()
    {
        if (dreamsound.isPlaying)
        {
            
            dreamsound.Stop();
        }
        else
        {
           
            dreamsound.Play();
        }
    }
    public void OtherButtonEffects()
    {
    }
}