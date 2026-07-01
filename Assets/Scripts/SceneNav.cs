using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNav : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void GotoScene(int sceneId)
    {
        SceneManager.LoadScene(sceneId);
    }

    public void ExitPlayInUnity()
    {
        EditorApplication.ExitPlaymode();
        //EditorApplication.isPlaying = false;
    }

    public void ExitApp()
    {
        Application.Quit();
    }
}
