using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableSelf : MonoBehaviour
{
   
    private void OnEnable()
    {
        Invoke("disableSelf", 0.1f);
    }
    void disableSelf() {

        this.enabled = false;

    }
}
