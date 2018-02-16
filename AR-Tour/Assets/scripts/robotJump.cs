using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robotJump : MonoBehaviour
{

    
    float force = 20;
    public Rigidbody rb;


    

    // Update is called once per frame
    public void OnMouseDown()
    {
        rb.AddForce(rb.transform.up * force, ForceMode.Impulse);
    }
}