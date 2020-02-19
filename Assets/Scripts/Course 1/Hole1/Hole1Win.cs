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

            Socre2.text = Score.Strokes.ToString();

            //Score.GetHighScore(HoleNumber

            UI.SetActive(false);
            
        }
    }
}