using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole1Win : MonoBehaviour
{
    [SerializeField] GameObject YouWin;
    [SerializeField] GameObject UI;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {           
            YouWin.SetActive(true);
            UI.SetActive(false);
        }
    }
}
