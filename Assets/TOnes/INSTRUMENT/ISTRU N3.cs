using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class yawni3 : MonoBehaviour
{
    public AudioSource yawnSound;

    void Start()
    {

        yawnSound.Pause();
    }

    public void yawnEffects()
    {
        if (yawnSound.isPlaying)
        {

            yawnSound.Stop();
        }
        else
        {

            yawnSound.Play();
        }
    }
    public void OtherButtonEffects()
    {
    }
} 