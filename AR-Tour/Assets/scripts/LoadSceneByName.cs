using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneByName : MonoBehaviour {


    public void LoadSceneName(string name)
    {

        LoadingScreenManager.LoadScene(name); 
    }

    public void LoadSceneWITHOUTLoadingScreen(string name)
    {

        SceneManager.LoadScene(name);
    }
}
