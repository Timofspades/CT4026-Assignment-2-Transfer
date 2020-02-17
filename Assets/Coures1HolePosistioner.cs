using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coures1HolePosistioner : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] GameObject Player2;

    [SerializeField] GameObject Hole1Posistion;
    [SerializeField] GameObject Hole2Posistion;
    [SerializeField] GameObject Hole3Posistion;
    [SerializeField] GameObject Hole4Posistion;
    [SerializeField] GameObject Hole5Posistion;
    [SerializeField] GameObject Hole6Posistion;
    [SerializeField] GameObject Hole7Posistion;
    [SerializeField] GameObject Hole8Posistion;
    [SerializeField] GameObject Hole9Posistion;

    void Start()
    {       
        if (1 == HolePosistioner.LevelSelect)
        {
            //Debug.Log("YES");
        }

        if (2 == HolePosistioner.LevelSelect)
        {
            Player.transform.position = Hole2Posistion.transform.position;
            Player2.transform.position = Hole2Posistion.transform.position;

            Player.transform.localRotation = Hole2Posistion.transform.localRotation;
            Player2.transform.localRotation = Hole2Posistion.transform.localRotation;
        }

        if (3 == HolePosistioner.LevelSelect)
        {
            Player.transform.localPosition = Hole3Posistion.transform.localPosition;
            Player2.transform.localPosition = Hole3Posistion.transform.localPosition;

            Player.transform.localRotation = Hole3Posistion.transform.localRotation;
            Player2.transform.localRotation = Hole3Posistion.transform.localRotation;
        }

        if (4 == HolePosistioner.LevelSelect)
        {
            //Debug.Log("YES");
        }

        if (5 == HolePosistioner.LevelSelect)
        {
            //Debug.Log("YES");
        }

        if (6 == HolePosistioner.LevelSelect)
        {
            //Debug.Log("YES");
        }

        if (7 == HolePosistioner.LevelSelect)
        {
            //Debug.Log("YES");
        }

        if (8 == HolePosistioner.LevelSelect)
        {
            //Debug.Log("YES");
        }

        if (9 == HolePosistioner.LevelSelect)
        {
            //Debug.Log("YES");
        }        
    }    
}
