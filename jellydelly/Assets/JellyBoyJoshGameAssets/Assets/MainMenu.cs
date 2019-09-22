using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject ImmersiveMenu;
    public bool isMenuActive = false;
    GameObject Player;
    public Vector3 offset;
    public bool SetPos = false;
    public DialogueFollow dialogueFollow;
    Vector3 temp;
    //bool shift = false;
    //public Animator anim;

    // Start is called before the first frame update
    private void Awake()
    {
        temp = dialogueFollow.ShiftPos;
    }
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");

        //anim.SetBool("Transition", false);
    }

    // Update is called once per frame
    void Update()
    {
        Player = GameObject.FindGameObjectWithTag("Player");

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isMenuActive = !isMenuActive;
            SetPos = true;
            //shift = true;
            //Application.Quit();
        }
        if (isMenuActive)
        {
            //anim.SetBool("Transition", false);

            ImmersiveMenu.SetActive(true);

        }
        if (!isMenuActive)
        {
            ImmersiveMenu.SetActive(false);

            dialogueFollow.ShiftPos = temp;
            //dialogueFollow.ShiftPos = dialogueFollow.ShiftPos + new Vector3(0f, -10f, 0f);


            //anim.SetBool("Transition", true);
            //Invoke("turnOffMenu", 0.7f);

        }
        if (SetPos) {
            ImmersiveMenu.transform.position = Player.transform.position + offset;
            dialogueFollow.ShiftPos = dialogueFollow.ShiftPos + new Vector3(0f, 10f, 0f);
            SetPos = false;
        }
       
    }
    //void turnOffMenu() {

    //    ImmersiveMenu.SetActive(false);

    //}
}
