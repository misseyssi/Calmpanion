using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioSource music1;
    public AudioSource music2;
    public AudioSource music3;
    public AudioSource music4;
    public AudioSource music5;
    public AudioSource music6;
    public AudioSource music7;
    public AudioSource music8;

    void Start()
    {
        StopAllMusic();
    }

    void StopAllMusic()
    {
        music1.Stop();
        music2.Stop();
        music3.Stop();
        music4.Stop();
        music5.Stop();
        music6.Stop();
        music7.Stop();
        music8.Stop();
    }

    public void PlayMusic1()
    {
        StopAllMusic();
        music1.Play();
    }

    public void PlayMusic2()
    {
        StopAllMusic();
        music2.Play();
    }

    public void PlayMusic3()
    {
        StopAllMusic();
        music3.Play();
    }

    public void PlayMusic4()
    {
        StopAllMusic();
        music4.Play();
    }

    public void PlayMusic5()
    {
        StopAllMusic();
        music5.Play();
    }

    public void PlayMusic6()
    {
        StopAllMusic();
        music6.Play();
    }

    public void PlayMusic7()
    {
        StopAllMusic();
        music7.Play();
    }

    public void PlayMusic8()
    {
        StopAllMusic();
        music8.Play();
    }
}
