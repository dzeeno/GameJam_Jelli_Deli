using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueEnabler1011 : MonoBehaviour
{
    bool isEntered = false;

    public DialoguePart10 dialoguePart10;
    public DialoguePart11 dialoguePart11;


    private void Update()
    {
        if (isEntered)
        {

            dialoguePart10.enabled = false;
            dialoguePart11.enabled = true;

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