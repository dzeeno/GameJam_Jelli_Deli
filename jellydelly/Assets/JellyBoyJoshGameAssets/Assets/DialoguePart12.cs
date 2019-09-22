using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialoguePart12 : MonoBehaviour
{
    //public Animator anim;

    //public Cam playerCam;

    public TextMesh dialogue;
    public string[] lines;
    public int index;
    public float typeSpeed;
    bool disableSpam = false;

    //public bool startTyping = false;
    //public DialogueFollow dialogueFollow;

    //public Color PlayerColour;
    //public Color FairyColour;
    //public Color ClericColour;

    public AudioSource SoundSource;
    public AudioClip PlayerClip;

    //public AudioClip WispClip;
    //public AudioClip OldManClip;

    public GameObject SpaceToContinue;

    //public GameObject playerMovement;

    //public string SoundObjectName;



    // Use this for initialization
    void Awake()
    {

        SoundSource = GetComponent<AudioSource>();

        SoundSource.clip = PlayerClip;
        disableSpam = false;

    }
    private void Start()
    {
        index = 0;
        //if (startTyping)
        //{
        StartCoroutine(typing());
        //}
    }
    // Update is called once per frame
    void Update()
    {
        if (index == lines.Length - 1)
        {
            SpaceToContinue.GetComponent<TextMesh>().text = "";

        }
        if (dialogue.text == lines[index])
        {
            disableSpam = false;
        }
        if ((Input.GetKeyDown(KeyCode.Space)) && (disableSpam == false))
        {
            NextLine();
        }



        if (disableSpam == false)
        {
            SpaceToContinue.SetActive(true);
        }
        if (disableSpam == true)
        {
            SpaceToContinue.SetActive(false);
        }
        //if (index < 9)
        //{
        //    playerMovement.GetComponent<Collider>().enabled = true;
        //}
        //if (index == 8)
        //{
        //    playerMovement.GetComponent<Collider>().enabled = false;
        //    playerMovement.GetComponent<MeshRenderer>().enabled = false;

        //}

    }
    IEnumerator typing()
    {

        foreach (char letter in lines[index])
        {
            dialogue.text += letter;
            disableSpam = true;

            SoundSource.Play();

            yield return new WaitForSeconds(typeSpeed);

        }

    }
    public void NextLine()
    {

        //anim.SetBool("IsNewLine", true);
        //Invoke("ResetAnim", 1f);
        disableSpam = true;

        if (index < lines.Length - 1)
        {
            index++;
            dialogue.text = "";
            StartCoroutine(typing());
        }
        else
        {
            dialogue.text = "";
        }
    }
    //private void ResetAnim()
    //{
    //    anim.SetBool("IsNewLine", false);

    //}
}