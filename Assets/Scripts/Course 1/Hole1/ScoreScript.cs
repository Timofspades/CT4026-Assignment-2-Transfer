using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreScript : MonoBehaviour
{
    static int Strokes = 0;

    [SerializeField] GameObject WinCanvas;

    private void Update()
    {
        GameObject.Find("Score").GetComponent<Text>().text = Strokes.ToString();
        GameObject.Find("Score2").GetComponent<Text>().text = Strokes.ToString();
    }    
    
    public void addStroke()
    {
        Strokes++;
    }

}
