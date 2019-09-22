using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermover : MonoBehaviour
{

    public Transform CurrentPos;
    //public Transform CurrentPlayer2;

    public Transform pos1;
    public Transform pos2;
    public Transform pos3;
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
