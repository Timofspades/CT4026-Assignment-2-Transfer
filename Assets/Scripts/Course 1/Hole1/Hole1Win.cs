using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hole1Win : MonoBehaviour
{
    static int Strokes = 0;

    [SerializeField] GameObject YouWin;
    [SerializeField] GameObject UI;
    [SerializeField] GameObject Socre2;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {           
            YouWin.SetActive(true);

            GameObject.Find("Score2").GetComponent<Text>().text = Strokes.ToString();

            UI.SetActive(false);
            
        }
    }
}

//GameObject.Find("Score2").GetComponent<Text>().text = Strokes.ToString();