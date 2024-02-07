using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalmNatureN6 : MonoBehaviour
{
    public AudioSource CalmNatureSound;
    // Use this for initialization
    void Start()
    {
        //so it doesn't play automatically
        CalmNatureSound.Pause();
    }

    public void CalmNatureffects()
    {
        if (CalmNatureSound.isPlaying)
        {
            // If the audio is currently playing, stop it
            CalmNatureSound.Stop();
        }
        else
        {
            // If the audio is not playing, start it
            CalmNatureSound.Play();
        }
    }
    public void OtherButtonEffects()
    {
    }
}
