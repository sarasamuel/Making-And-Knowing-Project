using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hide_hotspots : MonoBehaviour {

	public GameObject greenleafHotSpots;
	public GameObject moldHotSpots;
	public GameObject moldHotSpots_imprint;
	public GameObject metalHotSpots;
	public GameObject modeToggle;
	public Button hide_toggle;

	private bool hidden;

	// Use this for initialization
	void Start () {
		Button btn = hide_toggle.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);

		hidden = false;

		greenleafHotSpots.SetActive (false);
		moldHotSpots.SetActive (false);
		moldHotSpots_imprint.SetActive (false);
		metalHotSpots.SetActive (false);
		modeToggle.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () 
	{
		Debug.Log (hidden);
		if (hidden) {
			greenleafHotSpots.SetActive (true);
			moldHotSpots.SetActive (true);
			moldHotSpots_imprint.SetActive (true);
			metalHotSpots.SetActive (true);
			modeToggle.SetActive (true);
		}
		else 
		{
			greenleafHotSpots.SetActive (false);
			moldHotSpots.SetActive (false);
			moldHotSpots_imprint.SetActive (false);
			metalHotSpots.SetActive (false);
			modeToggle.SetActive (false);
		}

	}
	void TaskOnClick()
	{
	hidden = !hidden;
	}

	/*public void restore(){
		if (hidden) {
			greenleafHotSpots.SetActive (true);
			moldHotSpots.SetActive (true);
			moldHotSpots_imprint.SetActive (true);
			metalHotSpots.SetActive (true);
			modeToggle.SetActive (true);

			hidden = false;
		}

		if (!hidden) {
			greenleafHotSpots.SetActive (false);
			moldHotSpots.SetActive (false);
			moldHotSpots_imprint.SetActive (false);
			metalHotSpots.SetActive (false);
			modeToggle.SetActive (false);

			hidden = true;
		}*/

	//}



		

}
