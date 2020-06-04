using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class TimeSlowScript : MonoBehaviour
{
    [SerializeField] GameObject TimeSlowEffect;

    //this void will slow down time which helps the player make more differcult hits
    public void TimeSlow()
    {
        if (Time.timeScale == 1.0f)
        {
            Time.timeScale = 0.2f;
        }

        else
            Time.timeScale = 1.0f;

    }
    
    //this void puts a high satuation effect to be activated when time is slown down
    public void EffectOn()
    {
        if (TimeSlowEffect.activeSelf)
        {
            TimeSlowEffect.SetActive(false);
        }

        else
            TimeSlowEffect.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKey("space"))
        {
            Physics.gravity = new Vector3(0, -0.01F, 0);
        }

        else
            Physics.gravity = new Vector3(0, -13.0F, 0);
    }
    
}

