using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrganicChemTheoBromine : MonoBehaviour
{

    // Use this for initialization

    public GameObject Theobromine;
    public rigidBody THEO;
    int count = 0;
    public GameObject SynthesisInfo; 


    void onMouseDown() {
        if (GameObject == Theobromine && count % 2 == 0)
        {
            SynthesisInfo.SetActive(true);
            count++;
        }
        else if (GameObject == Theobromine && count %2 == 1 )
        {
            SynthesisInfo.SetActive(false);
            count++; 
        }
    }
	
}
