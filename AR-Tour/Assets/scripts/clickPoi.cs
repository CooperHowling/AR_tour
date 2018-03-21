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
    public GameObject econMenu;
    public GameObject philMenu;
	public GameObject player;
	public GameObject newCam;


	// Labels
	public GameObject histLabel;




    // Dictionary<string, GameObject> PoiDict = new Dictionary<string, GameObject>();


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
                        // LaunchIntoAir(rb);
                        print(name);

                        // Static Scences
                        if (name == "unc")
                        {

							// Switch To Menu Camera
							player.SetActive (false);
							newCam.SetActive (true);

							// Open Menu For Poi
                            uncMenu.SetActive(true);

							// Close All Other Poi's
                            historyMenu.SetActive(false);
                            eescMenu.SetActive(false);
                            ecologyMenu.SetActive(false);
                            philMenu.SetActive(false);
                            econMenu.SetActive(false);
                        }

                        if (name == "history")
                        {
							
							histLabel.SetActive (true);

						//	if (histLabel.activeSelf) {

						//		histLabel.SetActive (false);
						//	}

							// Open Menu For Poi
                            // historyMenu.SetActive(true);

							// Close All Other Poi's
                            uncMenu.SetActive(false);
                            eescMenu.SetActive(false);
                            ecologyMenu.SetActive(false);
                            philMenu.SetActive(false);
                            econMenu.SetActive(false);

                        }
                        if (name == "eesc")
                        {
							// Switch To Menu Camera
							player.SetActive (false);
							newCam.SetActive (true);

							// Open Menu For Poi
                            eescMenu.SetActive(true);

							// Close All Other Poi's
                            historyMenu.SetActive(false);
                            uncMenu.SetActive(false);
                            ecologyMenu.SetActive(false);
                            philMenu.SetActive(false);
                            econMenu.SetActive(false);

                        }
                        if (name == "ecology")
                        {
							// Switch To Menu Camera
							player.SetActive (false);
							newCam.SetActive (true);

							// Open Menu For Poi
                            ecologyMenu.SetActive(true);

							// Close All Other Poi's
                            eescMenu.SetActive(false);
                            historyMenu.SetActive(false);
                            uncMenu.SetActive(false);
                            philMenu.SetActive(false);
                            econMenu.SetActive(false);

                        }
                        if (name == "phil")
                        {
							// Switch To Menu Camera
							player.SetActive (false);
							newCam.SetActive (true);

							// Open Menu For Poi
                            philMenu.SetActive(true);

							// Close All Other Poi's
                            ecologyMenu.SetActive(false);
                            eescMenu.SetActive(false);
                            historyMenu.SetActive(false);
                            uncMenu.SetActive(false);
                            econMenu.SetActive(false);

                        }
                        if (name == "econ")
                        {
							// Switch To Menu Camera
							player.SetActive (false);
							newCam.SetActive (true);

							// Open Menu For Poi
                            econMenu.SetActive(true);

							// Close All Other Poi's
                            philMenu.SetActive(false);
                            ecologyMenu.SetActive(false);
                            eescMenu.SetActive(false);
                            historyMenu.SetActive(false);
                            uncMenu.SetActive(false);

                        }
                        // Ar Scenes
                        if (name == "simpleAr")
                        {
                            try
                            {
                                SceneManager.LoadScene(name, LoadSceneMode.Single);
                            }
                            catch (System.Exception)
                            {

                            }
                        }
                        if (name == "ChemAr")
                        {
                            try
                            {
                                SceneManager.LoadScene(name, LoadSceneMode.Single);
                            }
                            catch (System.Exception)
                            {

                            }
                        }
                        if (name == "PsychAr")
                        {
                            try
                            {
                                SceneManager.LoadScene(name, LoadSceneMode.Single);
                            }
                            catch (System.Exception)
                            {

                            }
                        }
                        if (name == "MicroBioAr")
                        {
                            try
                            {
                                SceneManager.LoadScene(name, LoadSceneMode.Single);
                            }
                            catch (System.Exception)
                            {

                            }
                        }
                        if (name == "ComputerScienceAr")
                        {
                            try
                            {
                                SceneManager.LoadScene(name, LoadSceneMode.Single);
                            }
                            catch (System.Exception)
                            {

                            }
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