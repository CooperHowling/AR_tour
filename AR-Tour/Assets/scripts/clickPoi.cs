using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clickPoi : MonoBehaviour
{

    public float force = 5;
    public GameObject barkMenu;
    public GameObject uncMenu;
    public GameObject historyMenu;

    
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

                        if (name == "science")
                        {
                            SceneManager.LoadScene("MicroBioAr",LoadSceneMode.Single);
                        }

                        if (name == "eme")
                        {
                            SceneManager.LoadScene("simpleAr",LoadSceneMode.Single);
                        }

                        if (name == "unc")
                        {
                            uncMenu.SetActive(true);
                        }

                        if (name == "history")
                        {
                            historyMenu.SetActive(true);

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
