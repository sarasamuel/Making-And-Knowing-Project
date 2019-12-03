using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowGallery : MonoBehaviour {

    public GameObject ImageGallery;
    private bool ToggleState;

    //animator reference
    private Animator anim;
    public Button btn; 


    public void Start()
    {
        Button btn_start = btn.GetComponent<Button>();
        ToggleState = false;
        ImageGallery.SetActive(false);
        btn_start.onClick.AddListener(ShowHide);

	}

    public void Update()
    {
        if (!ToggleState) {
            ImageGallery.SetActive(false);
        }
        else 
        {
            ImageGallery.SetActive(true);
        }
    }
	
	public void ShowHide () {
        ToggleState = ! ToggleState;
	}
}
