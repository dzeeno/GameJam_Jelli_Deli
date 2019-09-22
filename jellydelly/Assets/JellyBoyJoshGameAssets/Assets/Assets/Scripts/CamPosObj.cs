using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamPosObj : MonoBehaviour {

    Rigidbody rb;
    public GameObject player;
    public float speed;
    Animator anim;
    float CurrentSpeed;
    public float sprintSpeed;
    float normalSpeed;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();

    }
    private void Start()
    {
        normalSpeed = speed;


    }
    void FixedUpdate()
    {
        playerMovement();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void playerMovement()
    {

        rb.velocity = new Vector3(Input.GetAxis("Horizontal") * speed, rb.velocity.y, rb.velocity.z);
        transform.position = player.transform.position;

        //if (Input.GetAxis("Horizontal") == 0)
        //{

        //    rb.angularVelocity = Vector3.zero;
        //}
    }

}