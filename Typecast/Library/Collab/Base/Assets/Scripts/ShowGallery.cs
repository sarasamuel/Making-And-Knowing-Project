using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowGallery : MonoBehaviour {

    public GameObject ImageGallery;
    private bool ToggleState;

    //animator reference
    private Animator anim;


    public void Start()
    {
        ToggleState = false;
        ImageGallery.SetActive(false);
	}
	
	public void ShowHide () {
        if (ToggleState == false) {
            ImageGallery.SetActive(true);
            ToggleState = true;
        }
		else 
        {
            ImageGallery.SetActive(false);
            ToggleState = false;
        }
	}
}
