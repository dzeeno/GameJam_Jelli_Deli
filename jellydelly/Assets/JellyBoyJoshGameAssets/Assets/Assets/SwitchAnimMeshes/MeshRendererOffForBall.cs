using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshRendererOffForBall : MonoBehaviour
{
    public MeshRenderer Rendy;
    // Start is called before the first frame update
    void Start()
    {
        //Rendy = this.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Mouse0))
        //{
        //    Rendy.enabled = false;
        //}
        //if (Input.GetKeyUp(KeyCode.Mouse0))
        //{
        //    Rendy.enabled = true;
        //}
    }
    void SphereSkinOff()
    {

        Rendy.enabled = false;

    }
    void SphereSkinOn()
    {

        Rendy.enabled = true;

    }
}
