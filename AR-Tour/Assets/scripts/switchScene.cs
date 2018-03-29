using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switchScene : MonoBehaviour {

	public GameObject legend;

    public void SwitchScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

	public void openLegend() {

		legend.SetActive (true);

	}


	public void closeLegend() {

		legend.SetActive (false);

	}


}
