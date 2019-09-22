using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colldetector : MonoBehaviour
{
    public EyeFollowL eyeFollowL;
    // Start is called before the first frame update
    private void Start()
    {
        eyeFollowL = GameObject.FindGameObjectWithTag("LeftEye").GetComponent<EyeFollowL>();
    }
    private void Update()
    {
        eyeFollowL = GameObject.FindGameObjectWithTag("LeftEye").GetComponent<EyeFollowL>();

    }
    private void OnTriggerStay(Collider other)
    {
        if ((other.GetComponent<Collider>().tag == "SupaSpeeda"))

        {
            print("fuck me");
            eyeFollowL.notEnteredSpeed = true;
            //eyeFollowL.Smoothing = 0;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if ((other.GetComponent<Collider>().tag == "SupaSpeeda"))

        {
            print("fuck off");
            eyeFollowL.notEnteredSpeed = false;
            //eyeFollowL.Smoothing = 0;
        }
    }
}
