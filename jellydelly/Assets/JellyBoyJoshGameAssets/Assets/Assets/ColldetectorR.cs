using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColldetectorR : MonoBehaviour
{
    public EyeFollowR eyeFollowR;
    // Start is called before the first frame update
    private void Start()
    {
        eyeFollowR = GameObject.FindGameObjectWithTag("RightEye").GetComponent<EyeFollowR>();
    }
    private void Update()
    {
        eyeFollowR = GameObject.FindGameObjectWithTag("RightEye").GetComponent<EyeFollowR>();

    }
    private void OnTriggerStay(Collider other)
    {
        if ((other.GetComponent<Collider>().tag == "SupaSpeeda"))

        {
            print("fuck me");
            eyeFollowR.notEnteredSpeed = true;
            //eyeFollowL.Smoothing = 0;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if ((other.GetComponent<Collider>().tag == "SupaSpeeda"))

        {
            print("fuck off");
            eyeFollowR.notEnteredSpeed = false;
            //eyeFollowL.Smoothing = 0;
        }
    }
}