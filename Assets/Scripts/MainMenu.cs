using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Hole1 ()
    {
        SceneManager.LoadScene("Hole1");
    }

    public void Options()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void ExitGame ()
    {
        Application.Quit();
    }
}
