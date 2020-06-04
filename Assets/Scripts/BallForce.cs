using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallForce : MonoBehaviour
{
    float currentScore = 0f;    

    private GameObject maincamera;
    public Rigidbody BallRigidBody;

    private Slider PowerSlider;
    void Start()
    {
        //sets the score at the beginning of the scene to 0
        currentScore = 0;

        PowerSlider = GetComponent<Slider>();       

        maincamera = GameObject.FindGameObjectWithTag("MainCamera");
    }


    public void OnEndDrag()
    {
        //adds force on the ball in the direction that the camra is looking
        BallRigidBody.AddForce(maincamera.transform.forward * PowerSlider.value);
        //sets the slider value back to vero
        PowerSlider.value = 0f;
        //adds a hit on to the current score in game
        GetComponent<ScoreScript>().addStroke();        
    }
}
