using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSceneByName : MonoBehaviour {


    public void LoadSceneName(string name)
    {

        LoadingScreenManager.LoadScene(name); 
    }


}
