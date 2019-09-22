using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelDoc : MonoBehaviour {

    Rigidbody rb;


	// Use this for initialization
	void Start () {
        rb = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame 
	void Update () {

        //Debug.Log(rb.velocity.magnitude);

	}
    private void FixedUpdate()
    {
        float rbVel = rb.velocity.magnitude;

        Mathf.Clamp(rbVel, 0f, 45f);

        rb.velocity = rb.velocity.normalized * rbVel;
    }
}
