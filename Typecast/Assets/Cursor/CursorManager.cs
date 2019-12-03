using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour {


	public GameObject ring; 
	public GameObject pathing;
	public GameObject current;
	private float distanceFromCamera = 5;
	private Vector3 centerPos;
	public bool isPathing;
	public GameObject GreenLeaf; 
	public GameObject SandCube; 
	public GameObject Mold;
	public GameObject MetalLeaf;

	public float initialFingersDistance;
	public Vector3 initialScale;
	public Transform ScaleTransform;
	public int fingersOnScreen = 0;
	public bool hitGreenLeaf; 
	public bool hitSandCube; 
	public bool hitMold; 
	public bool hitMetalLeaf; 
	public float speed;


	public Camera cam;

	// Use this for initialization
	void Start () {
		current = ring;
		//centerPos = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, distanceFromCamera));
		centerPos = cam.transform.position;
		//Vector3 center = new Vector3(cam.transform.position.x, cam.transform.position.y, cam.transform.position.z + 1.0f);
		//centerPos = center;
		//current.transform.position = centerPos;
		hitGreenLeaf = false;
		hitSandCube = false;
		hitMold = false;
		hitMetalLeaf = false;
		speed = 0.001f;

	}
	
	// Update is called once per frame
	void Update () {
		//centerPos = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, distanceFromCamera));
		centerPos = new Vector3(cam.transform.position.x, cam.transform.position.y, cam.transform.position.z);

		//Vector3 center = new Vector3(cam.transform.position.x, cam.transform.position.y, cam.transform.position.z + 1.0f);
		//centerPos = center;
		//current.transform.position = centerPos;	
		RaycastHit hit;

		if (Physics.Raycast(current.transform.position, cam.transform.TransformDirection(Vector3.forward), out hit, 10.0f))
        {

        	if(hit.transform.tag == "GreenLeaf")
        	{
				pathing.transform.position = current.transform.position;
				current = pathing;
				pathing.SetActive(true);
				ring.SetActive(false);
        		hitGreenLeaf = true; 
        		hitSandCube = false;
				hitMold = false;
				hitMetalLeaf = false;
        	}
        	if(hit.transform.tag == "SandCube")
        	{
				pathing.transform.position = current.transform.position;
				current = pathing;
				pathing.SetActive(true);
				ring.SetActive(false);
        		hitGreenLeaf = false; 
        		hitSandCube = true;
				hitMold = false;
				hitMetalLeaf = false;
        	}
        	if(hit.transform.tag == "Mold")
        	{ 
				pathing.transform.position = current.transform.position;
				current = pathing;
				pathing.SetActive(true);
				ring.SetActive(false);
        	    hitGreenLeaf = false; 
        		hitSandCube = false;
				hitMold = true;
				hitMetalLeaf = false;
        		
        	}
        	if(hit.transform.tag == "MetalLeaf")
        	{
				pathing.transform.position = current.transform.position;
				current = pathing;
				pathing.SetActive(true);
				ring.SetActive(false);
        		hitGreenLeaf = false; 
        		hitSandCube = false;
				hitMold = false;
				hitMetalLeaf = true;
        	}


        }
        else 
		{
			ring.transform.position = current.transform.position;
			current = ring;
			ring.SetActive(true);
			pathing.SetActive(false);
        	hitGreenLeaf = false; 
    		hitSandCube = false;
			hitMold = false;
			hitMetalLeaf = false;
       		Debug.DrawRay(current.transform.position, cam.transform.TransformDirection( Vector3.forward) * 10.0f, Color.red, 5.0f, true);

		}
		Debug.DrawRay(current.transform.position, cam.transform.TransformDirection( Vector3.forward) * 10.0f, Color.red, 5.0f, true);

		fingersOnScreen = 0;
		foreach (Touch touch in Input.touches)
		{
			fingersOnScreen++; //Count fingers (or rather touches) on screen as you iterate through all screen touches.
			speed = .011f;
			//You need two fingers on screen to pinch.
			if (fingersOnScreen == 2)
			{
				//First set the initial distance between fingers so you can compare.
				if (touch.phase == TouchPhase.Began)
				{
					initialFingersDistance = Vector2.Distance(Input.touches[0].position, Input.touches[1].position);
					if (hitGreenLeaf)
						initialScale = GreenLeaf.transform.localScale;
					if (hitSandCube)
						initialScale = SandCube.transform.localScale;
					if (hitMold)
						initialScale = Mold.transform.localScale;
					if (hitMetalLeaf)
						initialScale = MetalLeaf.transform.localScale;
				}
				else
				{
					float currentFingersDistance = Vector2.Distance(Input.touches[0].position, Input.touches[1].position);

					float scaleFactor = (currentFingersDistance / initialFingersDistance);
					if(scaleFactor > 1)
					{
						if (hitGreenLeaf && GreenLeaf.transform.localScale.x < 2.0f)	
							GreenLeaf.transform.localScale = initialScale * scaleFactor;
						if (hitSandCube && SandCube.transform.localScale.x < 2.0f)	
							SandCube.transform.localScale = initialScale * scaleFactor;
						if (hitMold && Mold.transform.localScale.x < 2.0f)	
							Mold.transform.localScale = initialScale * scaleFactor;	
						if (hitMetalLeaf && MetalLeaf.transform.localScale.x < 2.0f)	
							MetalLeaf.transform.localScale = initialScale * scaleFactor;
					}

					if(scaleFactor < 1)
					{
						if (hitGreenLeaf && GreenLeaf.transform.localScale.x > 0.2f)	
							GreenLeaf.transform.localScale = initialScale * scaleFactor;
						if (hitSandCube && SandCube.transform.localScale.x > 0.2f)	
							SandCube.transform.localScale = initialScale * scaleFactor;
						if (hitMold && Mold.transform.localScale.x > 0.2f)	
							Mold.transform.localScale = initialScale * scaleFactor;	
						if (hitMetalLeaf && MetalLeaf.transform.localScale.x > 0.2f)	
							MetalLeaf.transform.localScale = initialScale * scaleFactor;
					}

				}

			}
			else if (fingersOnScreen == 1) {

					if (hitGreenLeaf)	
						GreenLeaf.transform.RotateAround (GreenLeaf.transform.up, Input.touches[0].deltaPosition.x * speed);
					if (hitSandCube)	
						SandCube.transform.RotateAround (SandCube.transform.up, Input.touches[0].deltaPosition.x * speed);
					if (hitMold)	
						Mold.transform.RotateAround (Mold.transform.up, Input.touches[0].deltaPosition.x * speed);
					if (hitMetalLeaf)	
						MetalLeaf.transform.RotateAround (MetalLeaf.transform.up, Input.touches[0].deltaPosition.x * speed);
				
		
			}
		}

				
		
	}


}
