using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showPOI : MonoBehaviour {

    public GameObject cubeshow;

    private void OnMouseOver()
    {
        if(Input.GetMouseButtonUp(0))
        {
            Debug.Log("TEST");
            cubeshow.SetActive(true);
          
        }
    }



}
