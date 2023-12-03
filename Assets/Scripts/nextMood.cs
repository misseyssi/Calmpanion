using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextMood : MonoBehaviour
{
    public string moodHome;
    public string moodbefore;
    public string moodafter;
    public string back;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void backTomenu()
    {
        SceneManager.LoadScene(back);

    }
    public void MoodHome()
    {
        SceneManager.LoadScene(moodHome);

    }
    public void MoodBefore()
    {
        SceneManager.LoadScene(moodbefore);

    }
    public void MoodAfter()
    {
        SceneManager.LoadScene(moodafter);

    }
}
