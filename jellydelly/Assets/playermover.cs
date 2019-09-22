using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermover : MonoBehaviour
{

    public Transform CurrentPos;
    //public Transform CurrentPlayer2;
    public GameObject beats;
    public GameObject beatPoint;

    public Transform pos1;
    public Transform pos2;
    public Transform pos3;

    public bool isAtPos1 = false;
    public bool isAtPos2 = false;
    public bool isAtPos3 = false;

    //public Transform LookPos2;


    public float Smoothing = 10f;
    public Vector3 FollowPos;
    public Vector3 ShiftPos;

    float TurnSpeed;
    Vector3 Velocity = Vector3.zero;

    private void Awake()
    {
        //LookPos = GameObject.FindGameObjectWithTag("Player").transform;
        //CurrentPlayer = GameObject.FindGameObjectWithTag("Player").transform;
        //lookPosHolder = LookPos;
        CurrentPos = pos1;

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            CurrentPos = pos1;

        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            CurrentPos = pos2;

        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            CurrentPos = pos3;

        }

        if (CurrentPos = pos1) {
            isAtPos1 = true;
            isAtPos2 = false;
            isAtPos3 = false;

        }
        if (CurrentPos = pos2)
        {
            isAtPos1 = false;
            isAtPos2 = true;
            isAtPos3 = false;
        }
        if (CurrentPos = pos3)
        {
            isAtPos1 = false;
            isAtPos2 = false;
            isAtPos3 = true;
        }

        if (isAtPos1) {
            //choosemenuitems
        }
        if (isAtPos2)
        {
            //are you ready for the beats?
            //yes = go to pos 3
            //no = go to pos 1
        }
        if (isAtPos3) {

            Instantiate(beats, beatPoint.transform.position, beatPoint.transform.rotation);

        }



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


    }
    void FixedUpdate()
    {

        //LookPos = GameObject.FindGameObjectWithTag("Player").transform;
        //CurrentPlayer = GameObject.FindGameObjectWithTag("Player").transform;

       


    }



    private void LateUpdate()
    {

        //Vector3 TrailPos = CurrentPos.transform.position + FollowPos;
        //Vector3 Smoothening = Vector3.SmoothDamp(transform.position, TrailPos, ref Velocity, Smoothing * Time.deltaTime);
        //transform.position = Smoothening;

        TurnSpeed = Input.GetAxis("Mouse X");
        //print(TurnSpeed);
        Vector3 TrailPos = CurrentPos.position + FollowPos + ShiftPos;
        Vector3 Smoothening = Vector3.SmoothDamp(transform.position, TrailPos, ref Velocity, Smoothing * Time.deltaTime);

        transform.position = Smoothening;

    }
}
