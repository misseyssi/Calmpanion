using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TonesButton : MonoBehaviour
{
    public AudioSource rainSound;

    // Use this for initialization
    void Start()
    {
        //so it doesn't play automatically
        rainSound.Pause();
    }

    public void rainEffects()
    {
        if (rainSound.isPlaying)
        {
            // If the audio is currently playing, stop it
            rainSound.Stop();
        }
        else
        {
            // If the audio is not playing, start it
            rainSound.Play();
        }
    }
    public void OtherButtonEffects()
    {
    }
}
        