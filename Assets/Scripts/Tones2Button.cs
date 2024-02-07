using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tones2Button : MonoBehaviour
{
    public string Tones2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Tones2Scene()
    {
        SceneManager.LoadScene(Tones2);
    }
}