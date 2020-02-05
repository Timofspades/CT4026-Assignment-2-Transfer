using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreScript : MonoBehaviour
{
    int Strokes = 0;

    private void Update()
    {
        GameObject.Find("Score").GetComponent<Text>().text = Strokes.ToString();
    }


    public void addStroke()
    {
        Strokes++;
    }

}
