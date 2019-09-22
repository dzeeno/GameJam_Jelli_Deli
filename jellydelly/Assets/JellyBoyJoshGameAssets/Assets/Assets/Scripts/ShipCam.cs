using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipCam : MonoBehaviour
{

    GameObject CurrentPlayer;
    GameObject LookPos;
    //[Range(0.01f, 20f)]
    public float Smoothing = 10f;
    public Vector3 FollowPos;
    // public GameObject Player;
    // public Vector3 midPlace = new Vector3 (0, 0, 0);

    public Vector3 UpOffset;


    Vector3 Velocity = Vector3.zero;
    private void Start()
    {
        CurrentPlayer = GameObject.FindGameObjectWithTag("Ship");
        LookPos = CurrentPlayer;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            FollowPos = FollowPos + UpOffset;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            FollowPos = FollowPos - UpOffset;
        }
        if (Input.GetKeyUp(KeyCode.C))
        {
            FollowPos = new Vector3(-0.65f, 10f, -10f);
        }
    }

    private void LateUpdate()
    {
        Vector3 TrailPos = CurrentPlayer.transform.position + FollowPos;
        Vector3 Smoothening = Vector3.SmoothDamp(transform.position, TrailPos, ref Velocity, Smoothing * Time.deltaTime);
        transform.position = Smoothening;
        transform.LookAt(LookPos.transform.position);

    }
}
