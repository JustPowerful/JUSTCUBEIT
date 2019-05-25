using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public void OnClickPlay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void OnClickSettings()
    {
        // Later
    }

    public void OnClickExit()
    {
        Application.Quit();
    }

    public void OnClickMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
