using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robotJump : MonoBehaviour
{


    float force = 50;
    public Rigidbody rb;
    float pose;



    void Start()
    {
        pose = rb.position.y;
        pose = Mathf.Round(pose);
    }

    // Update is called once per frame
    public void OnMouseDown()
    {
        float currentPose = Mathf.Round(rb.position.y);
       
       if (currentPose== (pose))
        {
            //rb.velocity = 20;
            
            rb.AddForce(rb.transform.up * force, ForceMode.Impulse);
       }
    }
}