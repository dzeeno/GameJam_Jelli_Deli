using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyStuff : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<Collider>().tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                this.transform.SetParent(other.transform);
            }
            if (Input.GetKeyUp(KeyCode.E))
            {
                this.transform.SetParent(null);
            }

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Collider>().tag == "Player")
        {
           
           
            
            
        }
    }
}
