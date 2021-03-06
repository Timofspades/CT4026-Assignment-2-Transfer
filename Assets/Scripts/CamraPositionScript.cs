﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamraPositionScript : MonoBehaviour
{
    public GameObject GolfBall;
    public GameObject GolfCamra;
    public GameObject CamPivot;
    public GameObject Arrow;

    public Vector3 CamOffset;

    float ZRot;
    float YRot;

    public float RotationSpeed;
    public float MobileRotationSpeedScalar = 0.2f;

    private bool MobileZonePressed = false;
    void Start()
    {
        Vector3 currentEuler = CamPivot.transform.eulerAngles;
        ZRot = currentEuler.z;
        YRot = currentEuler.y;

        GolfCamra.transform.localPosition = CamOffset;
    }


    void Update()
    {
        CamPivot.transform.position = GolfBall.transform.position;
        GolfCamra.transform.localPosition = CamOffset;

        float X = 0f;
        float Y = 0f;
#if UNITY_STANDLONE || UNITY_EDITOR
        X = Input.GetAxis("Mouse X") * RotationSpeed;
        Y = Input.GetAxis("Mouse Y") * RotationSpeed;

        //this code will only run when the game is on a Android device
#elif UNITY_ANDROID
        for (int i = 0; i < Input.touchCount; i++)
        {
            Touch touch = Input.touches[i];
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    break;
                case TouchPhase.Moved:
                    X = touch.deltaPosition.x * (RotationSpeed * MobileRotationSpeedScalar);
                    Y = touch.deltaPosition.y * (RotationSpeed * MobileRotationSpeedScalar);
                    break;
                case TouchPhase.Stationary:
                    break;
                case TouchPhase.Ended:
                    break;
                case TouchPhase.Canceled:
                    break;
            }
        }
#endif
        //this section of code allows me to control the camra when I am running the game throgh unity on my computer
        if (MobileZonePressed)
        {            
            ZRot -= Y * Time.deltaTime;
            YRot += X * Time.deltaTime;

            //this clamps the movement of the camra so the player can't easily fly  look up and fly away
            ZRot = Mathf.Clamp(ZRot, -2f, 80f);

            Vector3 currentEuler = CamPivot.transform.eulerAngles;

            CamPivot.transform.rotation = Quaternion.Euler(ZRot, YRot, currentEuler.z);
        }
    }

    public void OnMobileZoneDown()
    {
        MobileZonePressed = true;
    }

    public void OnMobileZoneUp()
    {
        MobileZonePressed = false;
    }
}
