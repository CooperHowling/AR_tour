using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GyroControlCameraNonAR : MonoBehaviour
{

    public GameObject Camera360;
    

    void OnEnable()
    {
        Input.gyro.enabled = true;
        Screen.orientation = ScreenOrientation.LandscapeLeft;

    }

    void Update()
    {
        Camera360.transform.Rotate(-Input.gyro.rotationRateUnbiased.x, -Input.gyro.rotationRateUnbiased.y, 0);
    }




}
