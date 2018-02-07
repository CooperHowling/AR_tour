using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectOnTime : MonoBehaviour {
    public GameObject Loader;
    public float timer;

	void Start () {

        Destroy(Loader, timer);

	}
	

}
