using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneSelect : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	




	}

	public void TransitionChangePlayerSize(){

		SceneManager.LoadScene ("ChangePlayerSizeLevel");
	}

	public void TransitionFlashLight(){

		SceneManager.LoadScene ("FlashlightLevel");
	}

	public void TransitionTiltBoard(){

		SceneManager.LoadScene ("TiltBoardLevel");
	}
}
