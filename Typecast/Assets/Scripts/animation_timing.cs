using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation_timing : MonoBehaviour {
	/**
	public GameObject sand_jug;
	public GameObject green_leaf;

	// Use this for initialization
	void Start () {
		sand_jug.GetComponent<pour> ().enabled = false;
		green_leaf.GetComponent<leaf_to_mold> ().enabled = false;

		Invoke ("leaf_to_mold_enable", 3f);
		Invoke ("sand_pour_start", 7f);
		Invoke ("sand_pour_stop", 11f);



	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void leaf_to_mold_enable(){
		green_leaf.GetComponent<leaf_to_mold> ().enabled = true;

	}

	void sand_pour_start(){

		sand_jug.GetComponent<pour> ().enabled = true;
		sand_jug.GetComponent<pour> ().pouring ();
	}

	void sand_pour_stop(){
		sand_jug.GetComponent<pour> ().stop_pour();

	}


**/
}
