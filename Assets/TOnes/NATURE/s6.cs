using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalmNatureN6 : MonoBehaviour
{
    public AudioSource CalmNatureSound;
    
    void Start()
    {
        
        CalmNatureSound.Pause();
    }

    public void CalmNatureffects()
    {
        if (CalmNatureSound.isPlaying)
        {
            
            CalmNatureSound.Stop();
        }
        else
        {
            
            CalmNatureSound.Play();
        }
    }
    public void OtherButtonEffects()
    {
    }
}
