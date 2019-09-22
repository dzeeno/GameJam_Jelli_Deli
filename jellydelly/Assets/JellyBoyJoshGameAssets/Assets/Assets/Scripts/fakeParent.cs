using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fakeParent : MonoBehaviour {

    public GameObject Parent;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        this.transform.position = Parent.transform.position;
	}
}
