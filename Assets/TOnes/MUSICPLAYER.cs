using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MUSICPLAYER : MonoBehaviour
{
    public AudioSource SRC;
    public AudioClip M1, M2, M3, M4, M5, M6, M7, M8;

    public void b1()
    {
        SRC.clip = M1;
        SRC.Play(); 
    }
    public void b2()
    {
        SRC.clip = M2;
        SRC.Play();
    }
    public void b3()
    {
        SRC.clip = M3;
        SRC.Play();
    }
    public void b4()
    {
        SRC.clip = M4;
        SRC.Play();
    }
    public void b5()
    {
        SRC.clip = M5;
        SRC.Play();
    }
    public void b6()
    {
        SRC.clip = M6;
        SRC.Play();
    }
    public void b7()
    {
        SRC.clip = M7;
        SRC.Play();
    }
    
    public void b8()
        {
            SRC.clip = M8;
            SRC.Play();
        }
        
    }
