using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroControlCamera : MonoBehaviour {

    public GameObject Camera;

    void Start()
    {
        Input.gyro.enabled = true;
    }

    void Update()
    {
        Camera.transform.Rotate(-Input.gyro.rotationRateUnbiased.x, -Input.gyro.rotationRateUnbiased.y, 0);
    }


}
