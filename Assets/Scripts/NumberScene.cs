using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NumberScene : MonoBehaviour
{
    public string five;
    public string four;
    public string three;
    public string two;
    public string one;
    public string menu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void mainMenuScene()
    {
        SceneManager.LoadScene(menu);

    }
    public void FiveScene()
    {
        SceneManager.LoadScene(five);

    }
    public void FourScene()
    {
        SceneManager.LoadScene(four);

    }
    public void ThreeScene()
    {
        SceneManager.LoadScene(three);

    }
    public void TwoScene()
    {
        SceneManager.LoadScene(two);

    }
    public void OneScene()
    {
        SceneManager.LoadScene(one);

    }
}
