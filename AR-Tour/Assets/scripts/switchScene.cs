using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switchScene : MonoBehaviour {

    public GameObject barkMenu;
    public GameObject uncMenu;
    public GameObject historyMenu;


    public void SwitchScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void CloseMenu()
    {
        barkMenu.SetActive(false);
        uncMenu.SetActive(false);
        historyMenu.SetActive(false);
    }

}
