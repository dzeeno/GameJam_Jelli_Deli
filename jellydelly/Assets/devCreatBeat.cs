using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class devCreatBeat : MonoBehaviour
{
    public GameObject beat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            Instantiate(beat, this.transform.position, Quaternion.identity);
        }
    }
}
