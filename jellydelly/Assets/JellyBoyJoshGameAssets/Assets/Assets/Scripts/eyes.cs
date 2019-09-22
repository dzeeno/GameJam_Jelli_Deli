using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eyes : MonoBehaviour {
    public Rigidbody rb;
    public Camera cam;

    // Use this for initialization
    void Awake()
    {
        rb = GameObject.FindGameObjectWithTag("DirectionObj").GetComponent<Rigidbody>();
        cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();

    }

    // Update is called once per frame
    void Update () {
        //StartCoroutine("Eyes");
        Eyes();


       

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    transform.LookAt(transform.position + Vector3.up);
        //}
        //if (Input.GetKeyUp(KeyCode.Space))
        //{
        //    transform.LookAt(transform.position + Vector3.down);
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    transform.LookAt(transform.position + Vector3.right);
        //}

    }
    private void Eyes() {

        transform.LookAt(this.transform.position  + rb.velocity);
        if (rb.velocity.magnitude <= 1f)
        {
            transform.LookAt(cam.transform.position);
        }
        //yield return new WaitForSeconds(0);



    }
}
