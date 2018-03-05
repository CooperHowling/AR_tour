using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour {

    public GameObject player;
    public GameObject capsule;
    public GameObject target;
    
    // Use this for initialization
    void Start () {
        //this is the position of the player
        Vector3 pos = player.transform.position;
        //set this position to the capsule position
        capsule.transform.position = pos;
        //set target to position of poi

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
