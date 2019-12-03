using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Fade_Menu : MonoBehaviour {
	public GameObject menu;
	public Button HS;
	public Button WIM;
	private bool open;

	// Use this for initialization
	void Start () {
		open = false;

		menu.GetComponent<Image> ().CrossFadeAlpha(0f, 0f, false);
		HS.GetComponent<Image> ().CrossFadeAlpha (0f, 0f, false);
		WIM.GetComponent<Image> ().CrossFadeAlpha (0f, 0f, false);
		HS.gameObject.SetActive (false);
		WIM.gameObject.SetActive (false);


		HS.GetComponentInChildren<Text> ().CrossFadeAlpha (0f, 0f, false);
		WIM.GetComponentInChildren<Text> ().CrossFadeAlpha (0f, 0f, false);


	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void appear(){
		if (!open) {
			HS.gameObject.SetActive (true);
			WIM.gameObject.SetActive (true);
			menu.GetComponent<Image> ().CrossFadeAlpha (1, 1f, false);
			HS.GetComponent<Image> ().CrossFadeAlpha (1f, 1f, false);
			WIM.GetComponent<Image> ().CrossFadeAlpha (1f, 1f, false);
			HS.GetComponentInChildren<Text> ().CrossFadeAlpha (1f, 1f, false);
			WIM.GetComponentInChildren<Text> ().CrossFadeAlpha (1f, 1f, false);
			open = true;

		} else {
			menu.GetComponent<Image> ().CrossFadeAlpha(0f, 1f, false);
			HS.GetComponent<Image> ().CrossFadeAlpha (0f, 1f, false);
			WIM.GetComponent<Image> ().CrossFadeAlpha (0f, 1f, false);

			HS.GetComponentInChildren<Text> ().CrossFadeAlpha (0f, 1f, false);
			WIM.GetComponentInChildren<Text> ().CrossFadeAlpha (0f, 1f, false);
			HS.gameObject.SetActive (false);
			WIM.gameObject.SetActive (false);

			open = false;
		}
			

	}
}
