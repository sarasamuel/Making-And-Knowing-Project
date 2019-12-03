using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class leaf_to_mold : MonoBehaviour {
	public GameObject fire;
	public GameObject jug;
	public bool start_animation;
	private Vector3 targetPos = new Vector3 (4.62f, 0.08f, -3.9f);
	private Quaternion targetRot = new Quaternion (179.9f, -264.5f, 0f, 1f);
	private float speed = 5f;
	private float startTime;
	private float journeyLength;
	private Vector3 startingPos;
	private Quaternion startingRot;
	private Quaternion rotationDiff;
	public Button startButton;
	public GameObject plane;
	public GameObject thickClayBase;


	public GameObject textPanel;
	public Text step1;
	public Text step2A;
	public Text step2B;
	public Text step3;
	public Text step4;
	public Text step5;
	public Text step6;
	public Text step7;
	public Text step8;
	public Text step9;
	public Text step10A;
	public Text step10B;
	public Text final;

	public GameObject nub;
	public GameObject nub_target;
	private bool nub_time;

	public GameObject straw1;
	public GameObject straw1_target;
	public GameObject straw2;
	public GameObject straw2_target;
	private bool straw_time;

	public GameObject claywalls;
	private bool wall_time;

	public GameObject plaster;
	public GameObject sandJug;
	private bool plaster_time;

	//	public GameObject upsideDownBase;
	private bool fiveTime;
	public GameObject parent;

	private float newtime;

	public GameObject flippingPlaneAir;
	public GameObject flippingPlaneTable;

	private bool put_down;

	private bool fade;
	public GameObject baseBottom;

	private bool sixTime;
	public GameObject walls_six;

	private bool sevenTime;

	public Transform newPlane;
	public Transform newPlane2;

	private bool eightTime;
	public GameObject bottomOfLeaf;


	private bool nineTime;

	private bool tenaTime;

	private bool tenbTime;

	private bool finalTextTime;

	public GameObject step8plane;

	public GameObject metalJug;

	public GameObject step9plane;

	public GameObject metalLeaf;
	// Use this for initialization

	void Awake(){

		nub_time = false;
		straw_time = false;
		wall_time = false;
		plaster_time = false;
		fiveTime = false;
		put_down = false;
		fade = false;
		sixTime = false;
		sevenTime = false;
		eightTime = false;
		Time.timeScale = 1;


		textPanel.GetComponent<Image> ().CrossFadeAlpha(0f, 0f, false);
		step1.GetComponent<Text> ().CrossFadeAlpha(0f, 0f, false);
		step2A.GetComponent<Text> ().CrossFadeAlpha(0f, 0f, false);
		step2B.GetComponent<Text> ().CrossFadeAlpha(0f, 0f, false);
		step3.GetComponent<Text> ().CrossFadeAlpha(0f, 0f, false);
		step4.GetComponent<Text> ().CrossFadeAlpha(0f, 0f, false);
		step5.GetComponent<Text> ().CrossFadeAlpha(0f, 0f, false);
		step6.GetComponent<Text> ().CrossFadeAlpha(0f, 0f, false);
		step7.GetComponent<Text> ().CrossFadeAlpha(0f, 0f, false);
		step8.GetComponent<Text> ().CrossFadeAlpha(0f, 0f, false);
		step9.GetComponent<Text> ().CrossFadeAlpha(0f, 0f, false);
		step10A.GetComponent<Text> ().CrossFadeAlpha(0f, 0f, false);
		step10B.GetComponent<Text> ().CrossFadeAlpha(0f, 0f, false);
		final.GetComponent<Text> ().CrossFadeAlpha(0f, 0f, false);



		startButton.gameObject.SetActive (true);
		start_animation = false;
		startingPos = this.transform.localPosition;
		startingRot = this.transform.localRotation;
	//	targetPos = plane.transform.position;
		targetPos = new Vector3(1.07f, -3.81f, 3.94f);
		fire.SetActive (false);
		metalLeaf.SetActive (false);

	}
	void Start () {
		metalLeaf.SetActive (false);


		textPanel.GetComponent<Image> ().CrossFadeAlpha(0f, 0f, false);
		step1.GetComponent<Text> ().CrossFadeAlpha(0f, 0f, false);
		step2A.GetComponent<Text> ().CrossFadeAlpha(0f, 0f, false);
		step2B.GetComponent<Text> ().CrossFadeAlpha(0f, 0f, false);
		step3.GetComponent<Text> ().CrossFadeAlpha(0f, 0f, false);
		step4.GetComponent<Text> ().CrossFadeAlpha(0f, 0f, false);
		step5.GetComponent<Text> ().CrossFadeAlpha(0f, 0f, false);
		step6.GetComponent<Text> ().CrossFadeAlpha(0f, 0f, false);
		step7.GetComponent<Text> ().CrossFadeAlpha(0f, 0f, false);
		step8.GetComponent<Text> ().CrossFadeAlpha(0f, 0f, false);
		step9.GetComponent<Text> ().CrossFadeAlpha(0f, 0f, false);
		step10A.GetComponent<Text> ().CrossFadeAlpha(0f, 0f, false);
		step10B.GetComponent<Text> ().CrossFadeAlpha(0f, 0f, false);
		final.GetComponent<Text> ().CrossFadeAlpha(0f, 0f, false);


		/**
		textPanel.GetComponent<Image> ().CrossFadeAlpha(0f, 0f, false);
		step1.GetComponent<Text> ().CrossFadeAlpha(0f, 0f, false);
		step2A.GetComponent<Text> ().CrossFadeAlpha(0f, 0f, false);
		step2B.GetComponent<Text> ().CrossFadeAlpha(0f, 0f, false);
		step3.GetComponent<Text> ().CrossFadeAlpha(0f, 0f, false);
		step4.GetComponent<Text> ().CrossFadeAlpha(0f, 0f, false);
		step5.GetComponent<Text> ().CrossFadeAlpha(0f, 0f, false);
		step6.GetComponent<Text> ().CrossFadeAlpha(0f, 0f, false);
		step7.GetComponent<Text> ().CrossFadeAlpha(0f, 0f, false);
		step8.GetComponent<Text> ().CrossFadeAlpha(0f, 0f, false);
		step9.GetComponent<Text> ().CrossFadeAlpha(0f, 0f, false);
		step10A.GetComponent<Text> ().CrossFadeAlpha(0f, 0f, false);
		step10B.GetComponent<Text> ().CrossFadeAlpha(0f, 0f, false);
		final.GetComponent<Text> ().CrossFadeAlpha(0f, 0f, false);



		startButton.gameObject.SetActive (true);
		start_animation = false;
		startingPos = this.transform.position;
		startingRot = this.transform.localRotation;
		targetPos = plane.transform.position;
		fire.SetActive (false);
**/
	}

	// Update is called once per frame
	void FixedUpdate () {

		//	transform.position = Vector3.MoveTowards (transform.position, targetPos, Time.deltaTime*.6f);
		if (start_animation==true){
			startButton.gameObject.SetActive (false);


			textPanel.GetComponent<Image>().CrossFadeAlpha(1, 1f, false);
			step1.GetComponent<Text> ().CrossFadeAlpha(1, 1f, false);

			Vector3 center = (startingPos + targetPos) * 0.5F;
			center -= new Vector3(0, 1, 0);
			Vector3 riseRelCenter = startingPos - center;
			Vector3 setRelCenter = targetPos - center;
			float fracComplete = (Time.time - startTime) / 4f;
			transform.localPosition = Vector3.Slerp(riseRelCenter, setRelCenter, fracComplete);
			transform.localPosition += center;


			fire.SetActive (true);
			Debug.Log(nub_time);


		}

		if (nub_time) {

			step1.GetComponent<Text> ().CrossFadeAlpha(0, .5f, false);
			step1.GetComponent<Text>().color=new Color(0f,0f,0f,0f);
			step2A.GetComponent<Text> ().CrossFadeAlpha(1, 1f, false);


			Vector3 center2 = (nub.transform.position + nub_target.transform.position) * 0.5F;
			center2 -= new Vector3 (0, 1, 0);
			Vector3 riseRelCenter2 = nub.transform.position - center2;
			Vector3 setRelCenter2 = nub_target.transform.position - center2;
			float fracComplete2 = (Time.time-newtime) / 1.001f;
			nub.transform.position = Vector3.Slerp(riseRelCenter2, setRelCenter2, fracComplete2);
			nub.transform.position += center2;


		}

		if (straw_time) {
			step2A.GetComponent<Text> ().CrossFadeAlpha(0, .5f, false);
			step2A.GetComponent<Text>().color=new Color(0f,0f,0f,0f);
			step2B.GetComponent<Text> ().CrossFadeAlpha(1, 1f, false);


			Vector3 center2 = (straw1.transform.position + straw1_target.transform.position) * 0.5F;
			center2 -= new Vector3 (0, 1, 0);
			Vector3 riseRelCenter2 = straw1.transform.position - center2;
			Vector3 setRelCenter2 = straw1_target.transform.position - center2;
			float fracComplete2 = (Time.time-newtime) / .7f;
			straw1.transform.position = Vector3.Slerp(riseRelCenter2, setRelCenter2, fracComplete2);
			straw1.transform.position += center2;

			Vector3 center3 = (straw2.transform.position + straw2_target.transform.position) * 0.6F;
			center3 -= new Vector3 (0, 1, 0);
			Vector3 riseRelCenter3 = straw2.transform.position - center3;
			Vector3 setRelCenter3 = straw2_target.transform.position - center3;
			float fracComplete3 = (Time.time-newtime) / .7f;
			straw2.transform.position = Vector3.Slerp(riseRelCenter3, setRelCenter3, fracComplete3);
			straw2.transform.position += center3;

		}

		if (wall_time) {
			step2B.GetComponent<Text> ().CrossFadeAlpha(0, .5f, false);
			step2B.GetComponent<Text>().color=new Color(0f,0f,0f,0f);
			step3.GetComponent<Text> ().CrossFadeAlpha(1, 1f, false);

			float max_height = 0.07f;

			if (claywalls.transform.localScale.z < max_height) {
				claywalls.transform.localScale += new Vector3 (0, 0, 1) * .01f * Time.deltaTime;
			}

		}

		if (plaster_time) {

			step3.GetComponent<Text> ().CrossFadeAlpha(0, .5f, false);
			step3.GetComponent<Text>().color=new Color(0f,0f,0f,0f);
			step4.GetComponent<Text> ().CrossFadeAlpha(1, 1f, false);

			float max_height = 80f;

			if (plaster.transform.localScale.y < max_height) {
				plaster.transform.localScale += new Vector3 (0, 1, 0) * 10f * Time.deltaTime;
			}

		}

		if (fiveTime) {
			step4.GetComponent<Text> ().CrossFadeAlpha(0, .5f, false);
			step4.GetComponent<Text>().color=new Color(0f,0f,0f,0f);
			step5.GetComponent<Text> ().CrossFadeAlpha(1, 1f, false);

			straw1.gameObject.SetActive (false);
			straw2.gameObject.SetActive (false);
			this.GetComponentInChildren<MeshRenderer> ().enabled = false;

			nub.SetActive (false);

			Vector3 startingPos = claywalls.transform.position;

			thickClayBase.transform.parent = claywalls.transform;

			Vector3 center2 = (claywalls.transform.position + flippingPlaneAir.transform.position) * 0.5F;
			center2 -= new Vector3 (0, 1, 0);
			Vector3 riseRelCenter2 = claywalls.transform.position - center2;
			Vector3 setRelCenter2 = flippingPlaneAir.transform.position - center2;
			float fracComplete2 = (Time.time-newtime) / .7f;
			claywalls.transform.position = Vector3.Slerp(riseRelCenter2, setRelCenter2, fracComplete2);
			claywalls.transform.position += center2;

			float totalRotation = 0;
			float rotationAmount = 90f;


			if(Mathf.Abs (totalRotation) < Mathf.Abs (rotationAmount)){
				float currentAngle = claywalls.transform.localRotation.eulerAngles.x;
				claywalls.transform.localRotation = Quaternion.AngleAxis(currentAngle + (Time.deltaTime * 30f), Vector3.right);
				totalRotation += Time.deltaTime * 30f;
			}

		}

		if (put_down) {
			claywalls.transform.position = flippingPlaneTable.transform.position;
		}

		if (fade) {
			thickClayBase.GetComponent<MeshRenderer> ().enabled = false;

			claywalls.GetComponentInChildren<MeshRenderer> ().enabled = false;

			baseBottom.GetComponent<MeshRenderer> ().enabled = false;
		}

		if (sixTime) {



			step5.GetComponent<Text> ().CrossFadeAlpha(0, .5f, false);
			step5.GetComponent<Text>().color=new Color(0f,0f,0f,0f);
			step6.GetComponent<Text> ().CrossFadeAlpha(1, 1f, false);

			walls_six.transform.position = plaster.transform.position;
			walls_six.GetComponent<MeshRenderer> ().enabled = true;

			float max_height = 0.07f;

			if (walls_six.transform.localScale.z < max_height) {
				walls_six.transform.localScale += new Vector3 (0, 0, 1) * .05f * Time.deltaTime;
			}


		}

		if (sevenTime) {
			step6.GetComponent<Text> ().CrossFadeAlpha(0, .5f, false);
			step6.GetComponent<Text>().color=new Color(0f,0f,0f,0f);
			step7.GetComponent<Text> ().CrossFadeAlpha(1, 1f, false);

			//		sandJug.GetComponent<pour> ().targetPos = newPlane.position;
			//		sandJug.GetComponent<pour> ().startTime = Time.time;
			//		sandJug.GetComponent<pour> ().plane = newPlane2.gameObject;


			float max_height = -40f;

			if (plaster.transform.localScale.y > max_height) {
				plaster.transform.localScale -= new Vector3 (0, 4, 0) * 8f * Time.deltaTime;
			}

		}

		if (eightTime) {

			step7.GetComponent<Text> ().CrossFadeAlpha(0, .5f, false);

			step7.GetComponent<Text>().color=new Color(0f,0f,0f,0f);

			step8.GetComponent<Text> ().CrossFadeAlpha(1, 1f, false);


			Vector3 startingPos = claywalls.transform.position;


			walls_six.transform.parent = claywalls.transform;


			bottomOfLeaf.SetActive (false);
			claywalls.transform.localRotation = step8plane.transform.localRotation;
			claywalls.transform.position = step8plane.transform.position;
		}


		if (nineTime){
			step8.GetComponent<Text> ().CrossFadeAlpha(0, .5f, false);

			step8.GetComponent<Text>().color=new Color(0f,0f,0f,0f);

			step9.GetComponent<Text> ().CrossFadeAlpha(1, 1f, false);

			metalJug.transform.localRotation = step9plane.transform.localRotation; 
			metalJug.transform.position = step9plane.transform.position; 


		}

		if (tenaTime) {

			metalJug.SetActive (false);

			step9.GetComponent<Text> ().CrossFadeAlpha(0, .5f, false);

			step9.GetComponent<Text>().color=new Color(0f,0f,0f,0f);

			step10A.GetComponent<Text> ().CrossFadeAlpha(1, 1f, false);

			metalLeaf.transform.position = step8plane.transform.position;

			claywalls.SetActive (false);

			metalLeaf.SetActive (true);

		}
			

		if (finalTextTime){
			step10A.GetComponent<Text> ().CrossFadeAlpha(0, .5f, false);

			step10A.GetComponent<Text>().color=new Color(0f,0f,0f,0f);

			final.GetComponent<Text> ().CrossFadeAlpha(1, 1f, false);

	//		metalLeaf.SetActive (false);


			CancelInvoke(); //PUT AT END

		}

	}

	public void begin(){

		start_animation = true;
		startTime = Time.time;

		Debug.Log("Start time " + startTime);
		jug.GetComponent<pour> ().startTime = Time.time;
		metalLeaf.SetActive (false);

			Invoke ("TwoA", (Time.realtimeSinceStartup - startTime) + 3f);

			Invoke ("TwoB", (Time.realtimeSinceStartup - startTime)  + 7f);
			Invoke ("Three", (Time.realtimeSinceStartup - startTime)  + 12f);
			Invoke ("start_pour", (Time.realtimeSinceStartup - startTime) + 25f);
			Invoke ("Four", (Time.realtimeSinceStartup - startTime) +26f);
			Invoke ("end_pour", (Time.realtimeSinceStartup - startTime) +33f);
			Invoke ("Five", (Time.realtimeSinceStartup - startTime) +34f);
			Invoke ("put_down_mold", (Time.realtimeSinceStartup - startTime) +40f);
			Invoke ("fade_mold", (Time.realtimeSinceStartup - startTime) +42f);
			Invoke ("Six", (Time.realtimeSinceStartup - startTime) +44f);
			Invoke ("Seven", (Time.realtimeSinceStartup - startTime) +47f);
			Invoke ("Eight", (Time.realtimeSinceStartup - startTime) +54f);
			Invoke ("Nine", (Time.realtimeSinceStartup - startTime) + 57f);
			Invoke ("tenA", (Time.realtimeSinceStartup - startTime) + 60f);
			Invoke ("finalStep", (Time.realtimeSinceStartup - startTime) + 63f);



	}

	public void start_pour(){
		jug.GetComponent<pour> ().pourtime = true;

	}

	public void end_pour(){
		start_animation = false;

		jug.GetComponent<pour> ().stop_pour ();
		//	jug.GetComponent<pour> ().putjugdown = false;
	}
	public void stop(){
		jug.GetComponent<pour> ().putjugdown = false;
	}


	void TwoA(){
		Debug.Log("2 a");
		nub_time = true;
		newtime = Time.time;
	}

	void TwoB(){

		straw_time = true;
		newtime = Time.time;
	}

	void Three(){
		wall_time = true;
	}

	void Four(){
		plaster_time = true;
		newtime = Time.time;

	}

	void Five(){
		newtime = Time.time;
		fiveTime = true;

	}

	void put_down_mold(){
		newtime = Time.time;
		put_down = true;
	}

	void fade_mold(){
		fade = true;
	}

	void Six(){
		newtime = Time.time;
		sixTime = true;

	}

	void Seven(){
		newtime = Time.time;
		sevenTime = true;

	}

	void Eight(){
		newtime = Time.time;
		eightTime = true;

	}

	void Nine(){
		newtime = Time.time;
		nineTime = true;

	}

	void tenA(){
		newtime = Time.time;
		tenaTime = true;

	}

	void finalStep(){
		newtime = Time.time;
		finalTextTime = true;
	}
}
