using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMenu : MonoBehaviour
{
    // Update is called once per frame
    public void SceneMenuScript(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
