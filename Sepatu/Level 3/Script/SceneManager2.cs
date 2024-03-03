using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager2 : MonoBehaviour
{

    public static ScenesManager2 instance;

    private void Awake()
    {
        instance = this;
    }

    public enum Scene
    {
        StartScreen,
        Level1
    }

    public void LoadScene(Scene scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }

    public void LoadNewGame()
    {
        SceneManager.LoadScene(Scene.Level1.ToString());
    }

    public void LoadNextScene(string sceneName)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(Scene.StartScreen.ToString());
    }
}
