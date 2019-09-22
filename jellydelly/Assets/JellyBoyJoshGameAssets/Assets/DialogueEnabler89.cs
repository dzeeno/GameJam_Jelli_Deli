using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueEnabler89 : MonoBehaviour
{
    bool isEntered = false;

    public DialoguePart8 dialoguePart8;
    public DialoguePart9 dialoguePart9;


    private void Update()
    {
        if (isEntered)
        {

            dialoguePart8.enabled = false;
            dialoguePart9.enabled = true;

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