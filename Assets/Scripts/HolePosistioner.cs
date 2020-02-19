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
        SceneManager.LoadScene("Hole " + HoleNum);
    }

}
