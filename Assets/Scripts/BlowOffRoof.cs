using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlowOffRoof : MonoBehaviour {

    private Rigidbody rb;
    public float thrust = 30f;
    public GameObject cameraRig;
    private bool alreadyBlownOff = false;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
		if(cameraRig.transform.localScale.x > 4.9f && alreadyBlownOff == false)
        {
            rb.useGravity = true;
            rb.isKinematic = false;
            rb.AddForce(transform.up * thrust);
            alreadyBlownOff = true;
        }

        if(alreadyBlownOff == true)
        {
            transform.Rotate(1f, 1f, 1f);
        }
	}
}
