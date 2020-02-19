using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallForce : MonoBehaviour
{
    float currentScore = 0f;
    //public Text Score;

    private GameObject maincamera;
    public Rigidbody BallRigidBody;

    private Slider PowerSlider;
    void Start()
    {
        currentScore = 0;

        PowerSlider = GetComponent<Slider>();       

        maincamera = GameObject.FindGameObjectWithTag("MainCamera");
    }


    public void OnEndDrag()
    {
        BallRigidBody.AddForce(maincamera.transform.forward * PowerSlider.value);
        PowerSlider.value = 0f;
        GetComponent<ScoreScript>().addStroke();        
    }
}
