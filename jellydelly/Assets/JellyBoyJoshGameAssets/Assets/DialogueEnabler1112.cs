using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueEnabler1112 : MonoBehaviour
{
    bool isEntered = false;

    public DialoguePart11 dialoguePart11;
    public DialoguePart12 dialoguePart12;


    private void Update()
    {
        if (isEntered)
        {

            dialoguePart11.enabled = false;
            dialoguePart12.enabled = true;

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