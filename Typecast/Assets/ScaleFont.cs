using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//[ExecuteInEditMode]


public class ScaleFont : MonoBehaviour {

	public Text text;
	public RectTransform rect;

	// Use this for initialization
	void Start () {
		text.resizeTextForBestFit = true;
	}

	// Update is called once per frame
	void Update () {
		if (Screen.width < Screen.height) { // Portrait mode
			rect.sizeDelta = new Vector2( 200f, 36.9f);
		} else {							// Landscape mode
			rect.sizeDelta = new Vector2( 300f, 36.9f);

		}
	}



}