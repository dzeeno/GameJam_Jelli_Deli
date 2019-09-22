using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueEnabler : MonoBehaviour
{
    bool isEntered = false;

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
        if (other.tag == "Player")
        {
            isEntered = true;

        }
    }
}





    //public string dialogueNumber;
    //public DialoguePart5 dialogue;
    //public int DialogueNumber;
    //// Start is called before the first frame update
    //void Start()
    //{
    //    dialogue = GameObject.Find(dialogueNumber).GetComponents<DialoguePart5>()[DialogueNumber];
    //}

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.GetComponent<Collider>().tag == "Player")
    //    {
    //        dialogue.enabled = true;
    //    }
//    //}

//}
