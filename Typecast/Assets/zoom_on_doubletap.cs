using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class zoom_on_doubletap : MonoBehaviour {

	float lastClick = 0f;
	float interval = 0.4f;
//	bool zoomedIn = false;
	Touch touch;

//	public RectTransform scaleTransform;
//	float startWidth;
//	float startHeight;
//	float margin;
	public Vector3 initialPosition;
	public Vector3 initialScale;
	public Vector3 doublePosition;
	public Vector3 doubleScale;

	// Use this for initialization
	void Start () {
		initialScale = transform.localScale;
		initialPosition = transform.localPosition;
		doubleScale = 2 * initialScale;
		doublePosition = 2 * doublePosition;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0) { //if there is any touch
//			touch = Input.GetTouch (0);
			transform.localScale = doubleScale;
			transform.localPosition = doublePosition;


//			if (touch.phase == TouchPhase.Ended) {
//				
//			
//			}
				
		} else {
			transform.localScale = initialScale;
			transform.localPosition = initialPosition;
		}
	}

//	public void OnPointerClick(PointerEventData eventData)
//	{
//		if ((lastClick+interval)>Time.time)
//		{
//			//is a double click 
//			if (!zoomedIn) {
//				// change size
//				transform.localScale = initialScale * 2;
//
//				// position + margin
//				transform.localPosition *= 2;
//
//				zoomedIn = true;
//			} else {
//				// set back to original size
//				transform.localScale = initialScale;
//
//				// position - margin
//				transform.localPosition = initialPosition;
//
//				zoomedIn = false;
//			}
//		}
//		lastClick = Time.time;
//	}


}
