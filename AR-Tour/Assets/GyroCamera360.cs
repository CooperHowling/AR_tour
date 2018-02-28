using UnityEngine;
using System.Collections;
public class GyroCamera360 : MonoBehaviour
{
    public GameObject camcam;


    void Start()
    {
        Input.gyro.enabled = true;
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }

    void Update()
    {
        camcam.transform.Rotate(-Input.gyro.rotationRateUnbiased.x, -Input.gyro.rotationRateUnbiased.y, 0);
        
    }


}