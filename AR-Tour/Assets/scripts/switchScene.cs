using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switchScene : MonoBehaviour {


    public GameObject historyMenu;


    public void SwitchScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void closeHistory()
    {
        historyMenu.SetActive(false);
    }

}
