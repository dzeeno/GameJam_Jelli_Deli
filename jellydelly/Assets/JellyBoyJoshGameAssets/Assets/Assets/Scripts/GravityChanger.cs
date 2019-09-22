using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityChanger : MonoBehaviour {


    void Awake () {

 
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            Physics.gravity = new Vector3(0f, -10f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Physics.gravity = new Vector3(-10f, 0f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Physics.gravity = new Vector3(10f, 0f, 0f);
        }

    }

    
}
