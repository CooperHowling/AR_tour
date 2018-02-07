using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadTargetSceneButton : MonoBehaviour {


    public void LoadSceneName(string name)
    {

        LoadingScreenManager.LoadScene(name);
    }


}
