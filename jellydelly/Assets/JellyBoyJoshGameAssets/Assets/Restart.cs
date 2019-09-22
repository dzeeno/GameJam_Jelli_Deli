using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Restart : MonoBehaviour
{
    public TextMesh text;
    bool Entered = false;
    private void Awake()
    {
        text = GetComponentInChildren<TextMesh>();
    }

    private void Update()
    {
        if ((Input.GetKeyDown(KeyCode.R) && (Entered)))
        {
            SceneManager.LoadScene(0);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().tag == "Player")
        {
            Entered = true;
            text.text = "Press 'R' to Confirm";

        }
    }
    private void OnEnable()
    {
        Entered = false;
        text.text = "Restart";

    }
}
