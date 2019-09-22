using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimSwitch : MonoBehaviour
{
    Animator anim;
    GameObject Player;
    // Start is called before the first frame update
    void Awake()
    {
        anim = GetComponent<Animator>();
        Player = GameObject.FindGameObjectWithTag("CubeHolder");
    }

    // Update is called once per frame
    void Update()
    {
        //Player = GameObject.FindGameObjectWithTag("Player");

        //this.transform.position = Player.transform.position + new Vector3(0f,0.23f,0f);
        //this.transform.rotation = Player.transform.rotation;
    }

    void TrueBool() {

        anim.SetBool("isSwitched", true);
    }
    void FalseAnim() {

        anim.SetBool("isSwitched", false);


    }
}
