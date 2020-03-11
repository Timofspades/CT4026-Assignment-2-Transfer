using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hole1Win : MonoBehaviour
{
    [SerializeField] GameObject YouWin;
    [SerializeField] GameObject UI;
    [SerializeField] Text Socre2;

    [SerializeField] int HoleNumber;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {           
            YouWin.SetActive(true);

            int CurrentScore = Score.Strokes;

            Socre2.text = CurrentScore.ToString();

            //int BestScore = Score.GetHighScore(HoleNumber

            UI.SetActive(false);
            
        }
    }
}