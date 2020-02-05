using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPadCollsion : MonoBehaviour
{
    [SerializeField] GameObject YouWin;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {           
            YouWin.SetActive(true);
        }
    }
}
