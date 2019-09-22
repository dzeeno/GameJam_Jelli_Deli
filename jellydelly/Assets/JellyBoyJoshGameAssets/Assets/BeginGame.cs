using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginGame : MonoBehaviour
{
    PlayerMovement Player;
    //public GameObject DropPart;
    public GameObject DropPart2;

    public GameObject Dialogue;

    public MorphAnim morphAnim;

    public PlayerSwitcher playerSwitcher;

    public TextMesh text;
    public Cam cam;
    Vector3 temp;

    bool hasStarted = false;

    // Start is called before the first frame update
    void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        Player.enabled = false;
        temp = cam.ShiftPos;
        cam.ShiftPos = cam.ShiftPos + new Vector3(0f, 40f, -40f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {

            Application.Quit();
            print("Quit");
        }
        if (Player == null)
        {
            return;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            hasStarted = true;
        }
        if (hasStarted) {
            cam.ShiftPos = temp;
            //DropPart.SetActive(false);
            DropPart2.SetActive(false);

            playerSwitcher.enabled = true;

            morphAnim.enabled = true;

            Player.enabled = true;
            Dialogue.SetActive(true);
            text.text = "";
            this.enabled = false;

        }
    }
}
