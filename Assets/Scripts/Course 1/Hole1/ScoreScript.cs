using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score
{
    private const int MaxCourses = 9;
    private const int MaxHoles = 9;
    public static int Strokes = 0;
    private static int[] HighScores = new int[MaxCourses * MaxHoles];

    public static void SetHighScore(int a_course, int a_hole, int score)
    {
        HighScores[1 * (a_course - 1) + (a_hole - 1)] = score;
    }

    public static int GetHighScore(int a_course, int a_hole)
    {
        return HighScores[1 * (a_course - 1) + (a_hole - 1)];
    }
}



    public class ScoreScript : MonoBehaviour
{
    private void Start()
    {
        Score.Strokes = 0;
    }

    private void Update()
    {        
        GameObject.Find("Score").GetComponent<Text>().text = Score.Strokes.ToString();        
    }        

    public void addStroke()
    {
        Score.Strokes++;
    }

}
