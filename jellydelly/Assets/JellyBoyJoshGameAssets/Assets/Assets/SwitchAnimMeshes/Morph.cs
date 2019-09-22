using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Morph : MonoBehaviour
{
    //public GameObject[] lines;
    public List<GameObject> Frames;

    public int index;
    public float typeSpeed;
    //public TextMesh dialogue;
    public bool disableSpam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator typing()
    {
        Frames = new List<GameObject>();
        //Frames.AddRange(GameObject.FindGameObjectsWithTag("player"));

        foreach (GameObject bone in Frames)
        {
            bone.SetActive(true);
            yield return new WaitForSeconds(typeSpeed);

        }

        //foreach (GameObject letter in Frames[index])
        //{
        //    dialogue.text += letter;
        //    disableSpam = true;


        //}

    }
    //public void NextLine()
    //{

    //    //disableSpam = true;

    //    if (Input.GetKeyDown(KeyCode.Mouse0))
    //    {
    //        index++;
    //        dialogue.text = "";
    //        StartCoroutine(typing());
    //    }
    //    if (Input.GetKeyUp(KeyCode.Mouse0))
    //    {
    //        dialogue.text = "";
    //    }
    //}
  
}
