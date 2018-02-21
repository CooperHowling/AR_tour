using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuCollide : MonoBehaviour {

    public GameObject historyMenu;
    public GameObject uncMenu;
    public GameObject eescMenu;
    public GameObject ecologyMenu;
    public GameObject philMenu;
    public GameObject econMenu;

    void OnCollision(Collision col)
    {

        if (col.gameObject.name == "unc")
        {
            uncMenu.SetActive(true);

            historyMenu.SetActive(false);
            eescMenu.SetActive(false);
            ecologyMenu.SetActive(false);
            philMenu.SetActive(false);
            econMenu.SetActive(false);
        }

        if (col.gameObject.name == "history")
        {
            historyMenu.SetActive(true);

            uncMenu.SetActive(false);
            eescMenu.SetActive(false);
            ecologyMenu.SetActive(false);
            philMenu.SetActive(false);
            econMenu.SetActive(false);

        }
        if (col.gameObject.name == "eesc")
        {
            eescMenu.SetActive(true);

            historyMenu.SetActive(false);
            uncMenu.SetActive(false);
            ecologyMenu.SetActive(false);
            philMenu.SetActive(false);
            econMenu.SetActive(false);

        }
        if (col.gameObject.name == "ecology")
        {
            ecologyMenu.SetActive(true);
            print(col.gameObject.name);

            eescMenu.SetActive(false);
            historyMenu.SetActive(false);
            uncMenu.SetActive(false);
            philMenu.SetActive(false);
            econMenu.SetActive(false);

        }
        if (col.gameObject.name == "phil")
        {
            philMenu.SetActive(true);

            ecologyMenu.SetActive(false);
            eescMenu.SetActive(false);
            historyMenu.SetActive(false);
            uncMenu.SetActive(false);
            econMenu.SetActive(false);

        }
        if (col.gameObject.name == "econ")
        {
            econMenu.SetActive(true);

            philMenu.SetActive(false);
            ecologyMenu.SetActive(false);
            eescMenu.SetActive(false);
            historyMenu.SetActive(false);
            uncMenu.SetActive(false);

        }
    }



}
