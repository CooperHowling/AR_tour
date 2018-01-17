using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SwitchPanel : MonoBehaviour
{

    public GameObject infoPanel;
    public GameObject picPanel;
    public GameObject vidPanel;

    public void openInfo()
    {
        infoPanel.SetActive(true);
        picPanel.SetActive(false);
        vidPanel.SetActive(false);
    }

    public void openPic()
    {
        infoPanel.SetActive(false);
        picPanel.SetActive(true);
        vidPanel.SetActive(false);
    }

    public void openVid()
    {
        infoPanel.SetActive(false);
        picPanel.SetActive(false);
        vidPanel.SetActive(true);
    }
}