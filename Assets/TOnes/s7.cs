using UnityEngine;
using UnityEngine.UI;

public class WeAreButton : MonoBehaviour
{
    public AudioSource WeAreSound;

    // Use this for initialization
    void Start()
    {
        //so it doesn't play automatically
        WeAreSound.Pause();
    }

    public void WeAreffects()
    {
        if (WeAreSound.isPlaying)
        {
            // If the audio is currently playing, stop it
            WeAreSound.Stop();
        }
        else
        {
            // If the audio is not playing, start it
            WeAreSound.Play();
        }
    }
    public void OtherButtonEffects()
    {
    }
}
