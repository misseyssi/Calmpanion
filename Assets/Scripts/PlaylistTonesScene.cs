using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaylistTonesScene : MonoBehaviour
{
    public string PlaylistScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void playlistmenuScene() 
    {
    SceneManager.LoadScene(PlaylistScene);
    }
}
