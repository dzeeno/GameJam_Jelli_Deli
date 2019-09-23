using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermover : MonoBehaviour
{

    public Transform CurrentPos;
    public GJ_PlayerCtrl GJ_PlayerCtrl;
    //public Transform CurrentPlayer2;
    public GameObject beats;
    public GameObject beatPoint;

    public GameObject playPos;

    public MSCameraController msCameraController;

    public Transform pos1;
    public Transform pos2;
    public Transform pos3;
    public Transform pos4;


    public Animator anim;

    public bool isAtPos1;
    public bool isAtPos2;
    public bool isAtPos3;
    public bool isAtPos4;


    public Camera fpsCam;

    public GameObject loopingSound;

    public Collider playercoll;

    bool createBeats;

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
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
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

        if (CurrentPos == pos1) {
            isAtPos1 = true;
            //isAtPos2 = false;
            //isAtPos3 = false;

        }
        if (CurrentPos == pos2)
        {
            isAtPos1 = false;
            isAtPos2 = true;
            isAtPos3 = false;
            isAtPos4 = false;

        }
        if (CurrentPos == pos3)
        {
            isAtPos1 = false;
            isAtPos2 = false;
            isAtPos3 = true;
            isAtPos4 = false;

        }
      

        if (isAtPos1) {
            //choosemenuitems
            GJ_PlayerCtrl.enabled = false;
        }
        if (isAtPos2)
        {
            //are you ready for the beats?
            //yes = go to pos 3
            //no = go to pos 1
            anim.enabled = true;

        }
        if (isAtPos3) {

            createBeats = true;
            isAtPos3 = false;
            GJ_PlayerCtrl.enabled = true;
            msCameraController.changeCamera = true;

            Invoke("End", 95f);

            //msCameraController.target = playPos.transform;
            //fpsCam.enabled = false;
            loopingSound.SetActive(false);


        }
        if (createBeats)
        {
            beats.SetActive(true);
            playercoll.enabled = true;

            createBeats = false;
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
    void End() {

        print("End the game");
    }
}
