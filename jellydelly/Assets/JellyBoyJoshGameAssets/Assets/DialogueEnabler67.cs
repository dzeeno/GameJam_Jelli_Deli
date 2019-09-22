using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueEnabler67 : MonoBehaviour
{
    bool isEntered = false;

    public DialoguePart6 dialoguePart6;
    public DialoguePart7 dialoguePart7;


    private void Update()
    {
        if (isEntered)
        {

            dialoguePart6.enabled = false;
            dialoguePart7.enabled = true;

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