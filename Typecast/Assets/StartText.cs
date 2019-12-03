using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartText : MonoBehaviour {

	public Image i;
	public Text t;
	// Use this for initialization
	void Start () 
	{
		i.gameObject.SetActive(true);
		t.gameObject.SetActive(true);
		
	}
	void Update()
	{
		foreach (Touch touch in Input.touches)
		{
			Destroy(t);
			Destroy(i);
			break;
		}
	}

}
