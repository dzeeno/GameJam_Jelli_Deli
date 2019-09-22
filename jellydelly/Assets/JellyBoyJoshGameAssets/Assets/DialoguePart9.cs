using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialoguePart9 : MonoBehaviour
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

    public GameObject playerMovement;

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

        ////////////////Story Info Handler////////////////
        if (index == 0)
        {
            SpaceToContinue.GetComponent<TextMesh>().text = "space to continue";
            disableSpam = false;
        }
        if (index < 10)
        {
            playerMovement.GetComponent<Collider>().enabled = true;
        }
        if (index == 9)
        {
            playerMovement.GetComponent<Animator>().SetBool("StartDissolve", true);


        }

        //if (index == 6)
        //{
        //    dialogue.color = FairyColour;
        //    dialogueFollow.CurrentPlayer = dialogueFollow.wisp;
        //    SoundSource.clip = WispClip;

        //    //playerCam.LookPos = playerCam.WispPos;

        //}
        //if (index == 7)
        //{
        //    dialogue.color = PlayerColour;
        //    dialogueFollow.CurrentPlayer = dialogueFollow.player;
        //    SoundSource.clip = PlayerClip;

        //}
        //if (index == 8)
        //{
        //    dialogue.color = FairyColour;
        //    dialogueFollow.CurrentPlayer = dialogueFollow.wisp;
        //    SoundSource.clip = WispClip;

        //}
        //if (index == 12)
        //{
        //    dialogue.color = PlayerColour;
        //    dialogueFollow.CurrentPlayer = dialogueFollow.player;
        //    SoundSource.clip = PlayerClip;

        //    //playerCam.LookPos = playerCam.PlayerPos;

        //}
        //if (index == 16)
        //{
        //    dialogue.color = FairyColour;
        //    dialogueFollow.CurrentPlayer = dialogueFollow.wisp;
        //    SoundSource.clip = WispClip;
        //    SpaceToContinue.GetComponent<TextMesh>().text = "";


        //}
        //if (index == 17)
        //{
        //    dialogue.color = PlayerColour;
        //    dialogueFollow.CurrentPlayer = dialogueFollow.player;
        //    SoundSource.clip = PlayerClip;

        //}

        //////////////////////////////////////////////////
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