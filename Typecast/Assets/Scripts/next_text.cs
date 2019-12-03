using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class next_text : MonoBehaviour {

	public Canvas step1;
	public Canvas step2;

	// Use this for initialization
	void Start () {
		step1.gameObject.SetActive (false);
		step2.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void switch_text(){
		if (step1.gameObject.activeSelf==false && step2.gameObject.activeSelf==false) {

			step1.gameObject.SetActive (true);
		} else if (step1.gameObject.activeSelf==true && step2.gameObject.activeSelf==false) {
			step1.gameObject.SetActive (false);

			step2.gameObject.SetActive (true);

		} 


	}
}
