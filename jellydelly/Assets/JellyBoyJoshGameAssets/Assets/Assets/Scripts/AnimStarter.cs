using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimStarter : MonoBehaviour
{
    Animator anim;
    public float animDelay;
    // Start is called before the first frame update
    void Start()
    {
        anim = this.GetComponentInChildren<Animator>();
        anim.enabled = false;
        Invoke("StartAnim", animDelay);
    }

    // Update is called once per frame
    void StartAnim() {

        anim.enabled = true;

    }
}

