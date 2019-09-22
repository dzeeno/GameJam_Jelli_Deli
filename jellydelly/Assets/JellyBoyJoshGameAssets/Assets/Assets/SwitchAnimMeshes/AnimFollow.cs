using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimFollow : MonoBehaviour
{
    Transform playerholder;

    Transform CurrentPlayer;
    //public Transform CurrentPlayer2;
    GameObject player;

    public Transform Sphere;
    Transform LookPos;
    //public Transform LookPos2;

    public float Smoothing = 10f;
    public Vector3 FollowPos;
    public Vector3 ShiftPos;

    float TurnSpeed;
    Vector3 Velocity = Vector3.zero;

    private void Awake()
    {
        LookPos = GameObject.FindGameObjectWithTag("Player").transform;
        CurrentPlayer = GameObject.FindGameObjectWithTag("Player").transform;
        playerholder = CurrentPlayer;
        player = GameObject.FindGameObjectWithTag("Player");
        //lookPosHolder = LookPos;

    }

    private void Update()
    {



        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            CurrentPlayer = Sphere.transform;
            LookPos = Sphere.transform;

        }
        //if (Input.GetKeyUp(KeyCode.Mouse0))
        //{

        //    playerholder = CurrentPlayer;
        //    lookPosHolder = LookPos;


        //}
        LookPos = GameObject.FindGameObjectWithTag("Player").transform;
        CurrentPlayer = GameObject.FindGameObjectWithTag("Player").transform;
        player = GameObject.FindGameObjectWithTag("Player");

        TurnSpeed = Input.GetAxis("Mouse X");
        //print(TurnSpeed);
        Vector3 TrailPos = CurrentPlayer.position + FollowPos + ShiftPos;
        Vector3 Smoothening = Vector3.SmoothDamp(transform.position, TrailPos, ref Velocity, Smoothing * Time.deltaTime);

        transform.position = Smoothening;
        transform.rotation = player.transform.rotation;
        //transform.LookAt(LookPos.transform.position + ShiftPos);

    }
    void FixedUpdate()
    {

      


    }



    private void LateUpdate()
    {

        //Vector3 TrailPos = CurrentPlayer.transform.position + FollowPos;
        //Vector3 Smoothening = Vector3.SmoothDamp(transform.position, TrailPos, ref Velocity, Smoothing * Time.deltaTime);
        //transform.position = Smoothening;

    }
}
