using UnityEngine;
using UnityEngine.UI;

public class SummerN7 : MonoBehaviour
{
    public AudioSource RemSummer;

   
    void Start()
    {
      
        RemSummer.Pause();
    }

    public void RemSummerffects()
    {
        if (RemSummer.isPlaying)
        {
           
            RemSummer.Stop();
        }
        else
        {
            
            RemSummer.Play();
        }
    }
    public void OtherButtonEffects()
    {
    }
}
