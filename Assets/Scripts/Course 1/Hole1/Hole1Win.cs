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

            int BestScore = Score.GetHighScore(GameState.Currentcourse, GameState.Currenthole);

            if(CurrentScore < BestScore || BestScore == 0)
            {
                Score.SetHighScore(GameState.Currentcourse, GameState.Currenthole, CurrentScore);
            }

            UI.SetActive(false);
            
        }
    }
}