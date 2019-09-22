using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueEnabler910 : MonoBehaviour
{
    bool isEntered = false;

    public DialoguePart9 dialoguePart9;
    public DialoguePart10 dialoguePart10;


    private void Update()
    {
        if (isEntered)
        {

            dialoguePart9.enabled = false;
            dialoguePart10.enabled = true;

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