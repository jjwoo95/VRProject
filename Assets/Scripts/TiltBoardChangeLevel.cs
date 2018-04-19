using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TiltBoardChangeLevel : MonoBehaviour {
    


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        string tag = other.tag;

        if(tag == "Goal")
        {
            SceneManager.LoadScene("TestLevel");
        }
    }
}
