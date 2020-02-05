using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallForce : MonoBehaviour
{
    private GameObject maincamera;
    public Rigidbody BallRigidBody;

    private Slider PowerSlider;
    void Start()
    {
        PowerSlider = GetComponent<Slider>();
        maincamera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    

    public void OnEndDrag()
    {
        BallRigidBody.AddForce(maincamera.transform.forward * PowerSlider.value);
        PowerSlider.value = 0f;
    }
}
