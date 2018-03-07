using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BiologyDNAInteraction : MonoBehaviour {

    public GameObject anti;
    public GameObject sense;
    int EO = 0; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit = new RaycastHit(); 

        if (Input.GetMouseButton(0))
        {
            if(Physics.Raycast(ray, out hit))
            {
                if (hit.collider.name == "DNA"  && EO%2 == 0)
                {
                    anti.SetActive(true);
                    sense.SetActive(false);
                    EO++;
                    Debug.Log(EO);
                }

                if (hit.collider.name == "DNA" && EO%2 == 1)
                {
                    anti.SetActive(false);
                    sense.SetActive(true);
                    EO++;
                    Debug.Log(EO); 
                }
            }
        }
	}
}
