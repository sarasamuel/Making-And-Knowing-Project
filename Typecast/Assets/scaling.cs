using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaling : MonoBehaviour {

	public float initialFingersDistance;
	public Vector3 initialScale;
	public Transform ScaleTransform;
	public float speed = 1.5f;
	public int fingersOnScreen = 0;
	public Vector3 minScale;
	public Vector3 maxScale;

	// Update is called once per frame

	void Start()
	{
		minScale = new Vector3 (0.5f, 0.5f, 0.5f);
		maxScale = new Vector3 (2.0f, 2.0f, 2.0f);
	}
	void Update()
	{
		
		fingersOnScreen = 0;
		foreach (Touch touch in Input.touches)
		{
			fingersOnScreen++; //Count fingers (or rather touches) on screen as you iterate through all screen touches.

			//You need two fingers on screen to pinch.
			if (fingersOnScreen == 2)
			{

				//First set the initial distance between fingers so you can compare.
				if (touch.phase == TouchPhase.Began)
				{
					initialFingersDistance = Vector2.Distance(Input.touches[0].position, Input.touches[1].position);
					initialScale = transform.localScale;
				}
				else
				{
					float currentFingersDistance = Vector2.Distance(Input.touches[0].position, Input.touches[1].position);

					float scaleFactor = (currentFingersDistance / initialFingersDistance);
					Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position - Input.GetTouch(1).position);
			        RaycastHit raycastHit;
			        if (Physics.Raycast(raycast, out raycastHit))
			        {

					
						raycastHit.collider.gameObject.transform.localScale = initialScale * scaleFactor;
						
					
						
					}
					//ScaleTransform.localScale = initialScale * scaleFactor;
				}
			}
				
		}
	}

	void OnMouseDrag(){
		if (fingersOnScreen == 1) {
			float xAxis = Input.GetAxis ("Mouse X") * speed;
			transform.RotateAround (Vector3.up, xAxis);
		}
	}
}
