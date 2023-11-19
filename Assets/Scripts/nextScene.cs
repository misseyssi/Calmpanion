using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextScene : MonoBehaviour
{
    public string menu1;
    public string memories;
    public string Diary;
    public string FiveToOne;
    public string Loading;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MenuScene()
    {
        SceneManager.LoadScene(menu1);
        
    }
    public void MemoriesScene()
    {
        
        SceneManager.LoadScene(memories);
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
}
