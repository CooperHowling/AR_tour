using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchPanel : MonoBehaviour
{

    public GameObject infoPanel;
    public GameObject picturePanel;
    public GameObject videoPanel; 

    public void activateInfo()
    {
        infoPanel.SetActive(true);
    }

    public void closeInfo()
    {
        infoPanel.SetActive(false);
    }

    public void activatePicture()
    {
        picturePanel.SetActive(true);
        print("hello");
    }

    public void closePictrue()
    {
        picturePanel.SetActive(false);
    }

    public void activateVideo()
    {
        videoPanel.SetActive(true);
    }

    public void closeVideo()
    {
        videoPanel.SetActive(false);
    }
}
