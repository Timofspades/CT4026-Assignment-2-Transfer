using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    private static bool scoresLoaded = false;
    private void Awake()
    {
        if(scoresLoaded == false)
        {
            scoresLoaded = true;
            Score.LoadHighScores();
        }
    }  

    public void Options()
    {
        SceneManager.LoadScene("Main Menu");
    }

    //this void allows me to load the main menu
    public void Menu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    //this void will exit the game
    public void ExitGame ()
    {
        Score.SaveHighScores();
        Application.Quit();
    }
}
