using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class MenuButtonScript : MonoBehaviour {

	public GameObject Menu;
	public GameObject Quad;

	public Animator AniMenu;
	public Animator AniQuad;
	// Use this for initialization


	public void ClickOnMe(){
		Menu.SetActive (true);
		Quad.SetActive (true);


		AniMenu = Menu.GetComponent<Animator> ();
		AniQuad = Quad.GetComponent<Animator> ();

		AniMenu.Play ("slide_out");
		AniQuad.Play ("Quadslide");

	}

	public void CloseMenu(){

		/* Animation animation1 = Menu.GetComponent<Animation> ();
		Animation animation2 = Quad.GetComponent<Animation> ();

		animation1["slide_out"].speed = -1;
		animation2["Quadslide"].speed = -1;

		animation1["slide_out"].time = animation1["slide_out"].length;
		animation2["Quadslide"].time = animation2["Quadslide"].length;


		animation1.Play ("slide_out");
		animation2.Play ("Quadslide");

		Menu.SetActive (false);
		Quad.SetActive (false);

		animation1["slide_out"].speed = 1;
		animation2["Quadslide"].speed = 1;

		animation1["slide_out"].time = 0;
		animation2["Quadslide"].time = 0; */


		AniMenu = Menu.GetComponent<Animator> ();
		AniQuad = Quad.GetComponent<Animator> ();

		AniMenu.Play ("ReverseSlideOut");
		AniQuad.Play ("ReverseQuadSlide");
	

		//Menu.SetActive (false);
		//Quad.SetActive (false);




	}


	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
