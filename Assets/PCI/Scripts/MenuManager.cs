using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public void LoadNextScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void Settings()
    {

    }

    public void Quit()
    {
        Application.Quit();
        Debug.LogWarning("Game Closed");
    }

}
