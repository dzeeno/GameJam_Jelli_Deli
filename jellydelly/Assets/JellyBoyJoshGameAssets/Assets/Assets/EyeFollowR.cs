using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeFollowR : MonoBehaviour
{
    Transform playerholder;

    Transform CurrentPlayer;
    //public Transform CurrentPlayer2;
    GameObject player;

    //public Transform Sphere;
    Transform LookPos;
    //public Transform LookPos2;
    Rigidbody rb;

    public float Smoothing = 0f;
    public Vector3 FollowPos;
    public Vector3 ShiftPos;

   public bool notEnteredSpeed = false;

    float TurnSpeed;
    Vector3 Velocity = Vector3.zero;

    private void Awake()
    {
        //LookPos = GameObject.FindGameObjectWithTag("EyeSocketLeft").transform;
        CurrentPlayer = GameObject.FindGameObjectWithTag("EyeSocketRight").transform;
        playerholder = CurrentPlayer;
        player = GameObject.FindGameObjectWithTag("EyeSocketRight");
        //lookPosHolder = LookPos;
        rb = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();


    }

    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.A)) {
        //    Smoothing = 0.2f;
        //}
        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    Smoothing = 0.2f;
        //}
        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    Smoothing = 0.2f;
        //}
        //if (Input.GetKeyDown(KeyCode.S))
        //{
        //    Smoothing = 0.2f;
        //}


        //if (Input.GetKeyDown(KeyCode.Mouse0))
        //{
        //    CurrentPlayer = Sphere.transform;
        //    LookPos = Sphere.transform;

        //}
        //if (Input.GetKeyUp(KeyCode.Mouse0))
        //{

        //    playerholder = CurrentPlayer;
        //    lookPosHolder = LookPos;


        //}
        //LookPos = GameObject.FindGameObjectWithTag("Player").transform;
        CurrentPlayer = GameObject.FindGameObjectWithTag("EyeSocketRight").transform;
        player = GameObject.FindGameObjectWithTag("EyeSocketRight");
        rb = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();

        if ((rb.velocity.magnitude >= 5) && (!notEnteredSpeed))
        {

            Smoothing = 2f;

        }
        if ((rb.velocity.magnitude >= 10) && (!notEnteredSpeed))
        {

            Smoothing = .2f;

        }
        if ((rb.velocity.magnitude <= 5) && (!notEnteredSpeed))
        {

            Smoothing = 3f;

        }
        if (notEnteredSpeed)
        {
            Smoothing = 0f;

        }

        TurnSpeed = Input.GetAxis("Mouse X");
        //print(TurnSpeed);
        Vector3 TrailPos = CurrentPlayer.position + FollowPos + ShiftPos;
        Vector3 Smoothening = Vector3.SmoothDamp(transform.position, TrailPos, ref Velocity, Smoothing * Time.deltaTime);

        transform.position = Smoothening;
        transform.rotation = player.transform.rotation;
        //transform.LookAt(LookPos.transform.position + ShiftPos);

    }
    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.GetComponent<Collider>().tag == "EyeMovementSpace")
    //    {
    //        Smoothing = 0.01f;
    //    }
    //}
    private void OnTriggerEnter(Collider other)
    {
        if ((other.GetComponent<Collider>().tag == "SupaSpeeda"))

        {
            print("fuck me");
            notEnteredSpeed = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if ((other.GetComponent<Collider>().tag == "SupaSpeeda"))

        {
            notEnteredSpeed = false;
        }
    }
}