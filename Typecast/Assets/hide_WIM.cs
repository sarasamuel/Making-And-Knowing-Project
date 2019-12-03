using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hide_WIM : MonoBehaviour {

	public GameObject WIM;
	public GameObject WIMBig;
	public GameObject Trapezoid;
	private bool hidden;

	// Use this for initialization
	void Start () {
		WIM.SetActive (false);
		WIMBig.SetActive (false);
		Trapezoid.SetActive (false);
		hidden = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void show(){
		if (hidden) {

			WIM.SetActive (true);
			WIMBig.SetActive (true);
			Trapezoid.SetActive (true);
			WIMBig.GetComponent<Image> ().CrossFadeAlpha (0f, 0f, false);
			Trapezoid.GetComponent<Image> ().CrossFadeAlpha(0f, 0f, false);
			hidden = false;

		} else if (!hidden) {

			WIM.SetActive (false);
			WIMBig.SetActive (false);
			Trapezoid.SetActive (false);
			hidden = true;

		}

	}
}
