using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideNumbers : MonoBehaviour {
	public bool isHistMode;
	public Slider mainSlider;
	public GameObject one_1;
	public GameObject two_1;
	public GameObject three_1;

	public GameObject one_2;
	public GameObject two_2;
	public GameObject three_2;

	// Use this for initialization
	void Start () {
		isHistMode = true;
		mainSlider.onValueChanged.AddListener(delegate {ValueChangeCheck(); });

		
	}
	
	// Update is called once per frame
	void Update () {
		if (isHistMode) 
		{
			one_1.SetActive (false);
			two_1.SetActive (false);
			three_1.SetActive (false);

			one_2.SetActive (false);
			two_2.SetActive (false);
			three_2.SetActive (false);

		}

		if (!isHistMode) 
		{
			one_1.SetActive (true);
			two_1.SetActive (true);
			three_1.SetActive (true);

			one_2.SetActive (true);
			two_2.SetActive (true);
			three_2.SetActive (true);

		}
		
	}
	public void ValueChangeCheck()
	{

		if (mainSlider.value == 0)
			isHistMode = true;
		if (mainSlider.value == 1)
			isHistMode = false;


	}
}
