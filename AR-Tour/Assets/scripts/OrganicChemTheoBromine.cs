using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrganicChemTheoBromine : MonoBehaviour
{

    // Use this for initialization

  
    public GameObject SynthesisInfo;
    int count = 0 ; 


    void OnMouseDown() {
        if (count % 2 == 0)
        {
            SynthesisInfo.SetActive(true);
            count++;
            Debug.Log("theobromine information");
        }
        else if (count %2 == 1 )
        {
            SynthesisInfo.SetActive(false);
            count++;
            Debug.Log("Goodbye Information on theobromine");

        }
    }
	
}
