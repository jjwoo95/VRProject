using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinscript : MonoBehaviour {
    float x = 0, y = 0, z = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        
        transform.eulerAngles = new Vector3(x, y, z);
        y += 3;

        if (y == 360)
        {
            y = 0;
        }

       
    }
}
