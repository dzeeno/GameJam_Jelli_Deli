using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneReset : MonoBehaviour
{
    public List<GameObject> Bones;

    Vector3 StartPos;
    Quaternion StartRot;


    // Start is called before the first frame update
    void Awake()
    {

        Bones = new List<GameObject>();
        Bones.AddRange(GameObject.FindGameObjectsWithTag("player"));

        foreach (GameObject bone in Bones)
        {
            StartPos = bone.transform.position;
            StartRot = bone.transform.rotation;

        }

    }

    // Update is called once per frame
    void Update()
    {

      

        foreach (GameObject bone in Bones)
        {
            if (Input.GetKeyUp(KeyCode.Mouse0))
            {

                bone.transform.position = new Vector3(0f, 0f, 0f);
                bone.transform.rotation = StartRot;
            }
        }
    }
}
