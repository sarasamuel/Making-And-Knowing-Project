using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selection : MonoBehaviour {
	public GameObject leaf;
	public GameObject box;
	public bool touched;

	// Use this for initialization
	void Start () {
		box.SetActive (false);
		touched = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0) && touched==false) {
			touched = true;
		}

		if (Input.GetMouseButtonDown (0) && touched==true) {
			touched = false;
		}


		if (touched) {
			box.SetActive (true);
		}

		if (!touched) {

			box.SetActive (false);
		}
	}
		
}
