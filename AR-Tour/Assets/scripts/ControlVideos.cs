using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlVideos: MonoBehaviour {

    public GameObject CameraForVideo;
    public GameObject MainCamera;
    public GameObject VideoPlayer;

    public static string YoutubeVideoCode;
    public string code = YoutubeVideoCode;
  
    void Start()
    {
        MainCamera.SetActive(true);
        CameraForVideo.SetActive(false);
        VideoPlayer.SetActive(false);
    }
	
    void Load2DVideo(string videocode)
    {

        YoutubeVideoCode = videocode;
        MainCamera.SetActive(false);
        CameraForVideo.SetActive(true);
        VideoPlayer.SetActive(true);

    }

    void Load360Video(string videocode)
    {
        SceneManager.LoadScene("360VideoVlayer");
        YoutubeVideoCode = videocode;
    }

    void Close2DVideo()
    {
        MainCamera.SetActive(true);
        CameraForVideo.SetActive(false);
        VideoPlayer.SetActive(false);
    }
}
