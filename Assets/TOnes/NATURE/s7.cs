using UnityEngine;
using UnityEngine.UI;

public class SummerN7 : MonoBehaviour
{
    public AudioSource RemSummer;

    // Use this for initialization
    void Start()
    {
        //so it doesn't play automatically
        RemSummer.Pause();
    }

    public void RemSummerffects()
    {
        if (RemSummer.isPlaying)
        {
            // If the audio is currently playing, stop it
            RemSummer.Stop();
        }
        else
        {
            // If the audio is not playing, start it
            RemSummer.Play();
        }
    }
    public void OtherButtonEffects()
    {
    }
}
