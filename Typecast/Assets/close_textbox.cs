using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class close_textbox : MonoBehaviour {

	public GameObject Textbox;


	// Use this for initialization
	void Start () {
		Textbox.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void hide(){

		Textbox.SetActive (false);

	}
}
