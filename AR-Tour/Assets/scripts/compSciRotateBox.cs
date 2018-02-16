using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class compSciRotateBox : MonoBehaviour
{

    float timeCounter = 0;
    float speed, radius;

    void Start()
    {
        speed = 1;
        radius = 200;
    }

    void Update()
    {
        timeCounter += Time.deltaTime * speed;

        float x = Mathf.Sin(timeCounter) * radius;
        float y = -57;
        float z = Mathf.Cos(timeCounter) * radius;

        transform.position = new Vector3(x, y, z);
    }
}