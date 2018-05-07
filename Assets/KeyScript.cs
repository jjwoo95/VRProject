using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour {

	public static int numKeys = 0;
	float x=0, y =0, z =0;
	// Use this for initialization
	void Start () {
		
		numKeys++;
		print (numKeys);
	}
	
	// Update is called once per frame
	void Update () {

		transform.eulerAngles = new Vector3 (x, y, z);
		y += 2;

		if (y == 360) {
			y = 0;
		}

	}

	void OnCollisionEnter(){

		numKeys--;
		print (numKeys);
		gameObject.SetActive (false);


	}



}
