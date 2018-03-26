using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LastARSceneManager : MonoBehaviour {


    public static string LastARScene;

	void Start () {

        LastARScene = SceneManager.GetActiveScene().name;
	}
	


}
