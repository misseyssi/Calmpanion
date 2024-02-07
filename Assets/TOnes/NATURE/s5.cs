using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdNature : MonoBehaviour
{
    public AudioSource BirdNatureSound;

    // Use this for initialization
    void Start()
    {
        //so it doesn't play automatically
        BirdNatureSound.Pause();
    }

    public void BirdNatureffects()
    {
        if (BirdNatureSound.isPlaying)
        {
            // If the audio is currently playing, stop it
            BirdNatureSound.Stop();
        }
        else
        {
            // If the audio is not playing, start it
            BirdNatureSound.Play();
        }
    }
    public void OtherButtonEffects()
    {
    }
}
