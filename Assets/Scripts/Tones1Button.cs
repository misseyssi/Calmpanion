using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tones1Button : MonoBehaviour
{
    public string Tones1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Tones1Scene()
    {
        SceneManager.LoadScene(Tones1);
    }
}