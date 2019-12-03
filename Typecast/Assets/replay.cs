using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class replay : MonoBehaviour {

	public GameObject outerParent_prefab;
	public GameObject old_outer_parent;
	public GameObject leafPrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void replayAnimation(){

		Vector3 newPos = old_outer_parent.transform.position;
		Quaternion newRot = old_outer_parent.transform.rotation;


		Instantiate(outerParent_prefab, newPos, newRot, leafPrefab.transform);

		Destroy (old_outer_parent);
		this.gameObject.SetActive(false);

	}
}
