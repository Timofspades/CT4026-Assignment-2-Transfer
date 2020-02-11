using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManager.LoadScene("Game Test Level");
    }

    public void Options()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void ExitGame ()
    {
        Application.Quit();
    }
}
