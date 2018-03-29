using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BiologyDNAInteraction : MonoBehaviour {

    public GameObject OFF;
    public GameObject alsoOFF;
    public GameObject ON;
    int tap = 0; 
   
    // Use this for initialization
    private void OnMouseDown()
    {
        OFF.SetActive(false);
        alsoOFF.SetActive(false);
        ON.SetActive(true);
        tap++;
        Debug.Log("tap Count:" + tap);

    }
}
