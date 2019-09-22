using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffMusic : MonoBehaviour
{
    public List<GameObject> ObjectsToTurnOff;
    bool isTurnedOn = false;
    public string TurnOffText;
    public string TurnOnText;
    public TextMesh textMesh;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject objectToTurnOff in ObjectsToTurnOff)
        {
            if (isTurnedOn)
            {
                objectToTurnOff.SetActive(false);
                textMesh.text = TurnOffText;
            }
            if (!isTurnedOn)
            {
                objectToTurnOff.SetActive(true);
                textMesh.text = TurnOnText;

            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().tag == "Player")
        {
            isTurnedOn = !isTurnedOn;
        }
    }
}
