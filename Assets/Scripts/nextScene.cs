using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextScene : MonoBehaviour
{
    public string applockScene;
    public string menu1;
    public string Diary;
    public string FiveToOne;
    public string Loading;
    public string meditate;
    public string moodtracker;
    public string tones;
    public string exit;
    public string darkMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

public void AppLockScene()
{
    SceneManager.LoadScene(applockScene);
}

    public void MenuScene()
    {
        SceneManager.LoadScene(menu1);
        
    }
    public void DiaryScene()
    {

        SceneManager.LoadScene(Diary);
    }
    public void fivefourthreetwoOne()
    {

        SceneManager.LoadScene(FiveToOne);
    }
    public void LoadingScene()
    {

        SceneManager.LoadScene(Loading);
    }
    public void meditateScene()
    {

        SceneManager.LoadScene(meditate);
    }
    public void TonesScene()
    {

        SceneManager.LoadScene(tones);
    }
    public void moodtrackerScene()
    {

        SceneManager.LoadScene(moodtracker);
    }
    public void ExitScene()
    {

        SceneManager.LoadScene(exit);
    }
    public void DarkMenuScene()
    {

        SceneManager.LoadScene(darkMenu);
    }
}
