using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clickPoi : MonoBehaviour
{

    public float force = 5;
    public GameObject uncMenu;
    public GameObject historyMenu;
    public GameObject eescMenu;
    public GameObject ecologyMenu;
    public GameObject compsciMenu;
    public GameObject anthroMenu;
    public GameObject resMenu;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform != null)
                {

                    Rigidbody rb;


                    if (rb = hit.transform.GetComponent<Rigidbody>())

                    {
                        string name = hit.transform.gameObject.name;
                        //PrintName(hit.transform.gameObject);
                        LaunchIntoAir(rb);
                        print(name);
                //AR POIs
                        if (name == "bio")
                        {
                            SceneManager.LoadScene("MicroBioAr",LoadSceneMode.Single);
                        }

                        if (name == "bark")
                        {
                            SceneManager.LoadScene("simpleAr",LoadSceneMode.Single);
                        }
                        if (name == "psych")
                        {
                            SceneManager.LoadScene("PsychAr", LoadSceneMode.Single);
                        }
                        if (name == "chem")
                        {
                            SceneManager.LoadScene("ChemAr", LoadSceneMode.Single);
                        }
                 //Non AR POIs
                        if (name == "unc")
                        {
                            uncMenu.SetActive(true);
                        }

                        if (name == "history")
                        {
                            historyMenu.SetActive(true);

                        }
                        if (name == "eesc")
                        {
                            eescMenu.SetActive(true);

                        }
                        if (name == "ecology")
                        {
                            ecologyMenu.SetActive(true);

                        }
                        if (name == "compsci")
                        {
                            compsciMenu.SetActive(true);

                        }
                        if (name == "anthro")
                        {
                            anthroMenu.SetActive(true);

                        }
                        if (name == "res")
                        {
                            resMenu.SetActive(true);

                        }

                    }
                }
            }
        }
    }

    private void PrintName(GameObject go)
    {
        print(go.name);
    }

    private void LaunchIntoAir(Rigidbody rig)
    {

        rig.AddForce(rig.transform.up * force, ForceMode.Impulse);


    }

}
