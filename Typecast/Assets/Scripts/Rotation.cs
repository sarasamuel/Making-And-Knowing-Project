using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {

	float speed = 0.5f;
	// Use this for initialization

	void OnMouseDrag(){
		float xAxis = Input.GetAxis ("Mouse X") * speed;
		transform.RotateAround (Vector3.up, xAxis);
	}
}
