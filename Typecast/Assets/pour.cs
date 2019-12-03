using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pour : MonoBehaviour {
	public GameObject leaf;
	public GameObject metalLeaf;
	public GameObject leafPlacingPlane;

	public bool pourtime;
	private Vector3 startingPos;
	public Vector3 targetPos;
	public float startTime;
	public GameObject plane;
	public GameObject waterfall;
	public bool putjugdown;
	public GameObject up_plane;
	public GameObject targetPosPlane;

	public GameObject sandMold;
	private Material oldSandMoldMat;
	public Material newSandMoldMat;

	public GameObject sandDome;
	public GameObject sandDomePlane;
	private Vector3 domeStartingPos;

	public GameObject lid;
	public GameObject lidPlane;
	public GameObject lidPlaneTable;

	public float endTime;
	public ParticleSystem fire;

//	public EllipsoidParticleEmitter dustBlow;

	private bool lid_time;
	private float newTime;
	private float newTime2;
	private float newTime3;


	private bool lid_back;

	private bool metalTime;

	public GameObject metalJug;
	public GameObject waterfall2;





	// Use this for initialization
	void Start () {




		lid.transform.position = lidPlaneTable.transform.position;
//		dustBlow.gameObject.SetActive (false);

		oldSandMoldMat = sandMold.GetComponent<MeshRenderer> ().material;
		domeStartingPos = sandDome.transform.position;

	//	waterfall.GetComponent<EllipsoidParticleEmitter> ().maxEnergy = 0f;
//		waterfall2.GetComponent<EllipsoidParticleEmitter> ().maxEnergy = 0f;

		startingPos = this.transform.position;
		targetPos = targetPosPlane.transform.position;
		startTime = Time.time;
		lid_time = false;
		metalTime = false;
	//	Invoke ("pouring", startingTime);
	//	Invoke ("stop_pour", endTime);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (pourtime == true) {
			//moving jug
			Vector3 center = (startingPos + targetPos) * 0.5F;
			center -= new Vector3 (0, 1, 0);
			Vector3 riseRelCenter = startingPos - center;
			Vector3 setRelCenter = targetPos - center;
			float fracComplete = (Time.time - startTime) / 4f;
			transform.position = Vector3.Slerp(riseRelCenter, setRelCenter, fracComplete);
			transform.position += center;

			Vector3 dir_to_target = transform.position - plane.transform.position;
			Quaternion lookRotation = Quaternion.LookRotation (dir_to_target);
			transform.rotation = Quaternion.Lerp (transform.rotation, lookRotation, Time.deltaTime * 2f);

			turnOnWater ();

	//		Invoke ("raiseSandDome", 2f);
	//		Invoke ("moveLid", 6f);
	//		Invoke("startMyFireParticleEmitter", 10f);
	//		Invoke ("putLidBack", 12f);
	//		Invoke ("startMyDustParticleEmitter", 17f);
	//		Invoke ("stopDustParticleEmitter", 19f);
	//		Invoke ("pourMetal", 21f);

		}

	
	

		if (putjugdown == true) {

			Vector3 dir_to_target = transform.position - up_plane.transform.position;
			Quaternion lookRotation = Quaternion.LookRotation (dir_to_target);
			transform.rotation = Quaternion.Lerp (transform.rotation, lookRotation, Time.deltaTime * 2f);

			Vector3 center = (startingPos + targetPos) * 0.5F;
			center -= new Vector3(0, 1, 0);
			Vector3 riseRelCenter = targetPos - center;
			Vector3 setRelCenter = startingPos - center;
			float fracComplete = (Time.time - startTime) / 5f;
			transform.position = Vector3.Slerp(riseRelCenter, setRelCenter, fracComplete);
			transform.position += center;

		}

		if (lid_time) {
			Vector3 center2 = (lidPlaneTable.transform.position + lidPlane.transform.position) * 0.5F;
			center2 -= new Vector3 (0, 1, 0);
			Vector3 riseRelCenter2 = lidPlaneTable.transform.position - center2;
			Vector3 setRelCenter2 = lidPlane.transform.position - center2;
			float fracComplete2 = (Time.time-newTime) / 3f;
			lid.transform.position = Vector3.Slerp(riseRelCenter2, setRelCenter2, fracComplete2);
			lid.transform.position += center2;

		}

		if (lid_back) {
			Vector3 center2 = (lidPlane.transform.position + lidPlaneTable.transform.position) * 0.5F;
			center2 -= new Vector3 (0, 1, 0);
			Vector3 riseRelCenter2 = lidPlane.transform.position - center2;
			Vector3 setRelCenter2 = lidPlaneTable.transform.position - center2;
			float fracComplete2 = (Time.time-newTime2) / 3f;
			lid.transform.position = Vector3.Slerp(riseRelCenter2, setRelCenter2, fracComplete2);
			lid.transform.position += center2;

		}
		if (metalTime) {

			Vector3 metalstartingPos = metalJug.transform.position;

			Vector3 center = (metalstartingPos + targetPos) * 0.5F;
			center -= new Vector3 (0, 1, 0);
			Vector3 riseRelCenter = metalstartingPos - center;
			Vector3 setRelCenter = targetPos - center;
			float fracComplete = (Time.time - newTime2) / 8f;
			metalJug.transform.position = Vector3.Slerp(riseRelCenter, setRelCenter, fracComplete);
			metalJug.transform.position += center;

			Vector3 dir_to_target = metalJug.transform.position - plane.transform.position;
			Quaternion lookRotation = Quaternion.LookRotation (dir_to_target);
			metalJug.transform.rotation = Quaternion.Lerp (metalJug.transform.rotation, lookRotation, Time.deltaTime * 2f);
	//		waterfall2.GetComponent<EllipsoidParticleEmitter> ().maxEnergy = 1.5f;

		//	metalLeaf.transform.position = leafPlacingPlane.transform.position;
			Vector3 center2 = (metalLeaf.transform.position + leafPlacingPlane.transform.position) * 0.5F;
			center2 -= new Vector3 (0, 1, 0);
			Vector3 riseRelCenter2 = metalLeaf.transform.position - center2;
			Vector3 setRelCenter2 = leafPlacingPlane.transform.position - center2;
			float fracComplete2 = (Time.time - newTime3) / 10f;
			metalLeaf.transform.position = Vector3.Slerp(riseRelCenter2, setRelCenter2, fracComplete2);
			metalLeaf.transform.position += center2;

		}
	
	}

	void turnOnWater(){
	//	waterfall.GetComponent<EllipsoidParticleEmitter> ().maxEnergy = 0f;

	
	}

	public void pouring(){
		pourtime = true;
	//	startTime = Time.time;

	}

	public void stop_pour(){

		pourtime = false;

		putjugdown = true;

//		if (waterfall != null) {
//			waterfall.GetComponent<EllipsoidParticleEmitter> ().maxEnergy = 0f;
//		}


	}


	void raiseSandDome(){
		Vector3 center2 = (domeStartingPos + sandDomePlane.transform.position) * 0.5F;
		center2 -= new Vector3 (0, 1, 0);
		Vector3 riseRelCenter2 = domeStartingPos - center2;
		Vector3 setRelCenter2 = sandDomePlane.transform.position - center2;
		float fracComplete2 = (Time.time - startTime) / 8f;
		sandDome.transform.position = Vector3.Slerp(riseRelCenter2, setRelCenter2, fracComplete2);
		sandDome.transform.position += center2;
		newTime = Time.time;
	}





	void stop(){
		putjugdown = false;


	}

	public void moveLid(){
		lid_time = true;

	}

	public void putLidBack(){

		lid_back = true;
		newTime2 = Time.time+.2f;


	}


	public void startMyFireParticleEmitter()
	{
		fire.Emit (5);
	}

	public void startMyDustParticleEmitter()
	{
		leaf.SetActive (false);

		sandDome.GetComponent<MeshRenderer> ().material = newSandMoldMat;
		sandMold.GetComponent<MeshRenderer> ().material = newSandMoldMat;

	//	dustBlow.gameObject.SetActive (true);
	//	dustBlow.Emit (1);

		Vector3 center2 = (domeStartingPos + sandDomePlane.transform.position) * 0.5F;
		center2 -= new Vector3 (0, 1, 0);
		Vector3 riseRelCenter2 = sandDomePlane.transform.position - center2;
		Vector3 setRelCenter2 = domeStartingPos - center2;
		float fracComplete2 = (Time.time - newTime2) / 8f;
		sandDome.transform.position = Vector3.Slerp(riseRelCenter2, setRelCenter2, fracComplete2);
		sandDome.transform.position += center2;
		newTime3 = Time.time+.5f;


	}

	public void stopDustParticleEmitter(){

	//	dustBlow.emit = false;

	}

	void pourMetal(){

		metalTime = true;
	//	metalLeaf.transform.position = leafPlacingPlane.transform.position;
	}

}
