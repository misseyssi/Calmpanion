using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dwc8 : MonoBehaviour
{
    public AudioSource dwcSound;

    void Start()
    {
      
        dwcSound.Pause();
    }

    public void dwcEffects()
    {
        if (dwcSound.isPlaying)
        {
   
            dwcSound.Stop();
        }
        else
        {
 
            dwcSound.Play();
        }
    }
    public void OtherButtonEffects()
    {
    }
}