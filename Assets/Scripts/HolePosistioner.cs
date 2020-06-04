using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HolePosistioner : MonoBehaviour
{
    public static int LevelSelect = 0;
    public static int CourseNum;
    public void LoadLevel (int HoleNum)
    {
        //this allows me to make a scene in unity and simple call it C3 H2 this tells unity with the help of this script that the scene is Course 3 Hole 2
        GameState.Currenthole = HoleNum;
        SceneManager.LoadScene("C" + GameState.Currentcourse + " H" + HoleNum);
    }

}
