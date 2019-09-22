using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnListOff : MonoBehaviour
{
    public List<GameObject> ObjectsToTurnOff;
    bool isTurnedOn = false;
    //public string TurnOffText;
    //public string TurnOnText;
    public TextMesh textMesh;
    bool freeRoamEnabled = false;
    string temp;

    // Start is called before the first frame update
    private void OnEnable()
    {
        isTurnedOn = false;

    }
    private void Start()
    {
        temp = textMesh.text;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isTurnedOn) {
            textMesh.text = temp;
        }
        if (freeRoamEnabled) {
            textMesh.text = "Free Roam Enabled";

        }
        foreach (GameObject objectToTurnOff in ObjectsToTurnOff)
        {
            if ((isTurnedOn) && (Input.GetKeyDown(KeyCode.T)))
            {
                objectToTurnOff.SetActive(false);
                textMesh.text = "Free Roam Enabled";
                freeRoamEnabled = true;

            }

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().tag == "Player")
        {
            isTurnedOn = true;
            textMesh.text = "Press 'T' to Confirm";
        }
    }
}
