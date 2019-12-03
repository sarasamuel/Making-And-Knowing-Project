using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zoom_map_appear : MonoBehaviour {
	public GameObject bigMap;
	public GameObject trapezoid;
	private bool open;

	// Use this for initialization
	void Start () {
		open = false;

		bigMap.GetComponent<Image> ().CrossFadeAlpha (0f, 0f, false);
		trapezoid.GetComponent<Image> ().CrossFadeAlpha(0f, 0f, false);
	}

	// Update is called once per frame
	void Update () {

	}

	public void appear(){
		if (!open) {
			bigMap.GetComponent<Image> ().CrossFadeAlpha (1f, 0.2f, false);
			trapezoid.GetComponent<Image> ().CrossFadeAlpha (1, 0.2f, false);

			open = true;

		} else {
			bigMap.GetComponent<Image> ().CrossFadeAlpha (0f, 0.2f, false);
			trapezoid.GetComponent<Image> ().CrossFadeAlpha(0f, 0.2f, false);

			open = false;
		}


	}
}
