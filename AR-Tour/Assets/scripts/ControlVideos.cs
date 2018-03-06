using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlVideos: MonoBehaviour {

    public GameObject CameraForVideo;
    public GameObject MainCamera;
    public GameObject VideoPlayer;
    public GameObject CloseButton;

    public static string YoutubeVideoCode;
    public string code = YoutubeVideoCode;
  
    void Start()
    {
        MainCamera.SetActive(true);
        CameraForVideo.SetActive(false);
        VideoPlayer.SetActive(false);
        CloseButton.SetActive(false);
    }
	
   public void Load2DVideo(string videocode)
    {

        YoutubeVideoCode = videocode;
        MainCamera.SetActive(false);
        CameraForVideo.SetActive(true);
        CloseButton.SetActive(true);
        VideoPlayer.SetActive(true);

    }

    public void Load360Video(string videocode)
    {
        SceneManager.LoadScene("360VideoPlayer");
        YoutubeVideoCode = videocode;
    }

    public void Close2DVideo()
    {
        MainCamera.SetActive(true);
        CameraForVideo.SetActive(false);
        VideoPlayer.SetActive(false);
        CloseButton.SetActive(false);
    }
}
