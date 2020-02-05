using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamraPositionScript : MonoBehaviour
{
    public GameObject GolfBall;
    public GameObject GolfCamra;
    public GameObject CamPivot;

    public Vector3 CamOffset;

    float ZRot;
    float YRot;

    public float RotationSpeed;
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

        if(Input.GetMouseButton(1))
        {
            float X = Input.GetAxis("Mouse X");
            float Y = Input.GetAxis("Mouse Y");

            ZRot -= Y * RotationSpeed * Time.deltaTime;
            YRot += X * RotationSpeed * Time.deltaTime;

            ZRot = Mathf.Clamp(ZRot, -80f, 80f);

            Vector3 currentEuler = CamPivot.transform.eulerAngles;

            CamPivot.transform.rotation = Quaternion.Euler(ZRot, YRot, currentEuler.z);
        }
    }
}
