using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueEnabler78 : MonoBehaviour
{
    bool isEntered = false;

    public DialoguePart7 dialoguePart7;
    public DialoguePart8 dialoguePart8;


    private void Update()
    {
        if (isEntered)
        {

            dialoguePart7.enabled = false;
            dialoguePart8.enabled = true;

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            isEntered = true;

        }
    }
}