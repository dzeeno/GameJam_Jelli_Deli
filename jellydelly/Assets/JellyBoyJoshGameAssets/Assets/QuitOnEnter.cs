using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitOnEnter : MonoBehaviour
{
    public TextMesh text;
    bool Entered = false;
    private void Awake()
    {
        text = GetComponentInChildren<TextMesh>();
    }

    private void Update()
    {
        if ((Input.GetKeyDown(KeyCode.F) && (Entered)))
        {
            print("Quit");
            Application.Quit();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().tag == "Player")
        {
            Entered = true;
            text.text = "Press 'F' to Confirm";
 
        }
    }
    private void OnEnable()
    {
        Entered = false;
        text.text = "Quit";

    }
}
