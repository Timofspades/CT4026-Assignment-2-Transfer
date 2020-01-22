using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallForce : MonoBehaviour
{
    private GameObject maincamera;
    void Start()
    {
        maincamera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    private void OnMouseDown()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(maincamera.transform.forward * 200.0f);
    }
}
