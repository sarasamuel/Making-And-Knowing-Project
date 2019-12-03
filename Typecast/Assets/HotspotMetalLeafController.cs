using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HotspotMetalLeafController : MonoBehaviour {


	public bool isHistMode;
	public Slider mainSlider;

	// Use this for initialization
	public Button hotspotButton1;
	public Button hotspotButton2;


	public Transform image1;
	public Transform image2;



	// Use this for initialization
	void Start () {
		isHistMode = true;

		Button hotspot_btn1 = hotspotButton1.GetComponent<Button>();
        hotspot_btn1.onClick.AddListener(delegate{DisplayText(1);});

        Button hotspot_btn2 = hotspotButton2.GetComponent<Button>();
        hotspot_btn2.onClick.AddListener(delegate{DisplayText(2);});



        image1.gameObject.SetActive(false);
        image2.gameObject.SetActive(false);
       	mainSlider.onValueChanged.AddListener(delegate {ValueChangeCheck(); });

	}

	void DisplayText(int idx_)
	{
		if(idx_ == 1)
		{
			if(image1.gameObject.activeSelf)
			{
				image1.gameObject.SetActive(false);
			}
			else 
			{

				image1.gameObject.SetActive (true);
						
			}
		}
		if(idx_ == 2)
		{
			if(image2.gameObject.activeSelf)
			{
				image2.gameObject.SetActive(false);
			}
			else 
			{

				image2.gameObject.SetActive (true);		
			}
		}


	}


		public void ValueChangeCheck()
	{
		image1.gameObject.SetActive(false);
		image2.gameObject.SetActive(false);

		if (mainSlider.value == 0)
			isHistMode = true;
		if (mainSlider.value == 1)
			isHistMode = false;


	}

	// Update is called once per frame
	void Update()
	{
		if (isHistMode) {
			hotspotButton1.gameObject.SetActive (true);
			hotspotButton2.gameObject.SetActive (false);

		} else {
			hotspotButton1.gameObject.SetActive (false);
			hotspotButton2.gameObject.SetActive (true);
		}


	}
}
