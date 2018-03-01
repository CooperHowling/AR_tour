 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VideoNameDontDestroy : MonoBehaviour {

    static public string VideoCode;
    public string YoutubeVideoCode = VideoCode; //this is just so that the video code is visible in Unity Editor

	public GameObject CameraForVideo;
	public GameObject MainCamera;
	public GameObject POI;

	public GameObject CloseButton;

	public GameObject VideoPlayer ;

	// Use this for initialization
	void Start () {
		VideoPlayer.SetActive (false); //Video Player stays Disabled until a button is pressed
		CameraForVideo.SetActive (false);
		CloseButton.SetActive (false);
        Debug.Log(VideoCode);
	}

    public void LoadVideoNonAR(string code) //for non-AR POI
    {
		CameraForVideo.SetActive (true); //Camera switches
		MainCamera.SetActive(false);

		POI.SetActive(false);

        VideoCode = code; //Sets the video URL
		VideoPlayer.SetActive(true);  //Enables the video player in-scene

		CloseButton.SetActive (true);

    }

	public void LoadVideoNewScene(string code) //For AR POI
	{
		VideoCode = code;
		SceneManager.LoadScene("Play Video");  // goes to the video player scene
	}
	
    public void Load360Video(string code)
    {
		VideoCode = code; //Sets the video URL
        SceneManager.LoadScene("360videoplayer");
    }

	public void CloseVideoPlayer(){

		CloseButton.SetActive (false);

		VideoPlayer.SetActive (false);  //Disable video player
		CameraForVideo.SetActive (false); 
		MainCamera.SetActive (true); //Switch back to main camera.
		POI.SetActive(true);


	}

}
