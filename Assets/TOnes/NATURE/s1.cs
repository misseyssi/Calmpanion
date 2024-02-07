using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuyanButton : MonoBehaviour
{
    public AudioSource duyanSound;

    // Use this for initialization
    void Start()
    {
        //so it doesn't play automatically
        duyanSound.Pause();
    }

    public void duyanEffects()
    {
        if (duyanSound.isPlaying)
        {
            // If the audio is currently playing, stop it
            duyanSound.Stop();
        }
        else
        {
            // If the audio is not playing, start it
            duyanSound.Play();
        }
    }
    public void OtherButtonEffects()
    {
    }
}
        