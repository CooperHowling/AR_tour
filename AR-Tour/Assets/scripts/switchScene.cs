using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class switchScene : MonoBehaviour {

    public GameObject poiPanel;
    public bool ButtonOn = false;
    public Button MyButton;

    public void SwitchScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void BeenClicked()
    {
        ButtonOn = !ButtonOn;
        if (ButtonOn)
        {
            poiPanel.SetActive(false);
        }

    }


}
