using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowGallery : MonoBehaviour {

    public GameObject ImageGallery;
    private bool ToggleState;

    public void Start()
    {
        ToggleState = false;
        ImageGallery.SetActive(false);
	}
	
	public void ShowHide () {
        if (ToggleState == true) {
            ImageGallery.SetActive(false);
            ToggleState = false;
        }
		else 
        {
            ImageGallery.SetActive(true);
            ToggleState = true;
        }
	}
}
