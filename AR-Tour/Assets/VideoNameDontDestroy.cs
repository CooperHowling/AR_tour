using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VideoNameDontDestroy : MonoBehaviour {

    static public string VideoCode;
    public string code = VideoCode;

	// Use this for initialization
	void Start () {

        Debug.Log(VideoCode);
	}

    public void LoadVideo(string code)
    {
        VideoCode = code;
        SceneManager.LoadScene("Play Video");
    }
	
    public void Load360Video(string code)
    {
        VideoCode = code;
        SceneManager.LoadScene("360videoplayer");
    }
}
