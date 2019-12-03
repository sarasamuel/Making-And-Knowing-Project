using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HotspotController : MonoBehaviour {

	public bool isHistMode;
	public Slider mainSlider;

	// Use this for initialization
	public Button hotspotButton1;
	public Button hotspotButton2;
	public Button hotspotButton3;
	public Button hotspotButton4;

	public Transform image1;
	public Transform image2;
	public Transform image3;
	public Transform image4;

	public Transform image5;
	public Transform image6;


	public GameObject one_1;
	public GameObject two_1;
	public GameObject three_1;

	public GameObject one_2;
	public GameObject two_2;
	public GameObject three_2;


	void Start () 
	{
		isHistMode = true;

		Button hotspot_btn1 = hotspotButton1.GetComponent<Button>();
        hotspot_btn1.onClick.AddListener(delegate{DisplayText(1);});

        Button hotspot_btn2 = hotspotButton2.GetComponent<Button>();
        hotspot_btn2.onClick.AddListener(delegate{DisplayText(2);});


		Button hotspot_btn3 = hotspotButton3.GetComponent<Button>();
        hotspot_btn3.onClick.AddListener(delegate{DisplayText(3);});

		Button hotspot_btn4 = hotspotButton4.GetComponent<Button>();
        hotspot_btn4.onClick.AddListener(delegate{DisplayText(4);});

        image1.gameObject.SetActive(false);
        image2.gameObject.SetActive(false);
        image3.gameObject.SetActive(false);
        image4.gameObject.SetActive(false);
		image5.gameObject.SetActive(false);
		image6.gameObject.SetActive(false);

		mainSlider.onValueChanged.AddListener(delegate {ValueChangeCheck(); });



	}
	
	void DisplayText(int idx_)
	{
		if(idx_ == 1)
		{
			if(image1.gameObject.activeSelf || image5.gameObject.activeSelf)
			{
				image1.gameObject.SetActive(false);
				image5.gameObject.SetActive(false);
				image3.gameObject.SetActive(false);
			}
			else 
			{
		        image2.gameObject.SetActive(false);
		        image3.gameObject.SetActive(false);
		        image4.gameObject.SetActive(false);
				image6.gameObject.SetActive (false);

				if (isHistMode) {
					image1.gameObject.SetActive (true);
					image5.gameObject.SetActive (false);
				} 
				else {
					image1.gameObject.SetActive (false);
					image5.gameObject.SetActive (true);
					
				}
					
			}
		}

		if(idx_ == 2)
		{

			if(image2.gameObject.activeSelf || image6.gameObject.activeSelf)
			{
				image2.gameObject.SetActive(false);
				image6.gameObject.SetActive(false);
			}
			else 
			{
		        image1.gameObject.SetActive(false);
		        image3.gameObject.SetActive(false);
		        image4.gameObject.SetActive(false);
				image5.gameObject.SetActive (false);
				if (isHistMode) {
					image2.gameObject.SetActive (true);
					image6.gameObject.SetActive (false);
				} 
				else {
					image2.gameObject.SetActive (false);
					image6.gameObject.SetActive (true);

				}			}
		}		

		if(idx_ == 3)
		{
			if(image3.gameObject.activeSelf)
			{
				image3.gameObject.SetActive(false);
			}
			else 
			{
		        image2.gameObject.SetActive(false);
		        image1.gameObject.SetActive(false);
		        image4.gameObject.SetActive(false);
		        image3.gameObject.SetActive(true);
			}
			
		}		

		if(idx_ == 4)
		{
			if(image4.gameObject.activeSelf)
			{
				image4.gameObject.SetActive(false);
			}
			else 
			{
		        image2.gameObject.SetActive(false);
		        image3.gameObject.SetActive(false);
		        image1.gameObject.SetActive(false);
		        image4.gameObject.SetActive(true);
			}
		}
	}

	public void ValueChangeCheck()
	{
		image1.gameObject.SetActive(false);
		image2.gameObject.SetActive(false);
        image3.gameObject.SetActive(false);
        image4.gameObject.SetActive(false);
        image5.gameObject.SetActive(false);
		image6.gameObject.SetActive (false);
		if (mainSlider.value == 0)
			isHistMode = true;
		if (mainSlider.value == 1)
			isHistMode = false;


	}


	void Update()
	{
		if (isHistMode) {
			hotspotButton3.gameObject.SetActive (false);
			hotspotButton4.gameObject.SetActive (true);

		} else {
			hotspotButton3.gameObject.SetActive (true);
			hotspotButton4.gameObject.SetActive (false);
		}

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
}
