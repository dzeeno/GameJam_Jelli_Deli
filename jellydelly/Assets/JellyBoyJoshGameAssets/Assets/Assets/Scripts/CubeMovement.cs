using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour {

    public GameObject Player;
    public float Movespeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W)) {

            transform.Rotate(0f,Movespeed,0f);
             
        }
        if (Input.GetKey(KeyCode.S))
        {

            transform.Rotate(0f, -Movespeed, 0f);

        }
        if (Input.GetKey(KeyCode.A))
        {

            transform.Rotate(Movespeed,0f, 0f);

        }
        if (Input.GetKey(KeyCode.D))
        {

            transform.Rotate(-Movespeed, 0f, 0f);

        }
    }
}
