using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s5 : MonoBehaviour
{
    public AudioSource sonataSound;

    // Use this for initialization
    void Start()
    {
        //so it doesn't play automatically
        sonataSound.Pause();
    }

    public void sonataffects()
    {
        if (sonataSound.isPlaying)
        {
            // If the audio is currently playing, stop it
            sonataSound.Stop();
        }
        else
        {
            // If the audio is not playing, start it
            sonataSound.Play();
        }
    }
    public void OtherButtonEffects()
    {
    }
}
