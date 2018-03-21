using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BiologyDNAInteraction : MonoBehaviour {

    public GameObject ladder;
    public GameObject anti;
    public GameObject sense;
    public GameObject red;
    public GameObject blue; 
    public GameObject a,b,c,d,e,f,g,h,i;

    float speed = 10f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(Vector3.down, speed * Time.deltaTime);
       
	}
}
