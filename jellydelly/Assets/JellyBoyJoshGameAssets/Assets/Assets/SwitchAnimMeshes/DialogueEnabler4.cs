using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueEnabler4 : MonoBehaviour {
    public bool isEntered = false;

    public DialoguePart5 dialoguePart5;
    public DialoguePart6 dialoguePart6;


    private void Update()
    {
        if (isEntered)
        {

            dialoguePart5.enabled = false;
            dialoguePart6.enabled = true;

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().tag == "Player")
        {
            isEntered = true;

        }
    }
}
