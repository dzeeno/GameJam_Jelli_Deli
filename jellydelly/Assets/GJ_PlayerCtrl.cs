using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GJ_PlayerCtrl : MonoBehaviour
{
    public GameObject Player;
    public GameObject ScoreSFX;

    public bool hasAnimated;
    public bool Hit = false;
    public Animator anim;

    public Text ScoreTxt;
    public GameObject ScoreObj;
    public int Score = 0;
    public AudioSource SFX;
    public AudioClip[] S_Clip;
    private AudioClip A_Sound;
    public AudioSource Hit_S;

    //public float smoothing = 2.0f;

    //private Vector2 M_look;
    //private Vector2 smoothV;
    public float Move_Speed = 10f;
    public float Move_SpeedV = 10f;

    private float moveHor ;
    private float moveVert ;



    // Start is called before the first frame update
    void Start()
    {
        Player = this.gameObject ;
        Cursor.visible = false ;
        ScoreObj = GameObject.Find("Scoretext");
        ScoreTxt = ScoreObj.GetComponent<Text>();
        //ScoreSFX = GameObject.Find("Score Sound");
        SFX = ScoreSFX.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        P_Move () ;
        ScoreTxt.text = "SCORE: " + Score;
        if (hasAnimated) {
            Invoke("stopAnim", 0.33f);
            hasAnimated = false;
        }
        if (Score % 100 == 0)
        {
            int Index = Random.Range(0,4);
            A_Sound = S_Clip[Index];
            SFX.clip = A_Sound;
            SFX.Play() ;
        }
        if (Hit == true)
        {
            Hit_S.pitch = Random.Range(0.9f, 1f);
            Hit_S.Play();
            Hit = false;
        }

    }
    void stopAnim() {

        anim.SetBool("isHit", false);

    }

    private void P_Move()
    {
        float moveHor = Input.GetAxis("Mouse X") * Move_Speed;
        float moveVert = Input.GetAxis("Mouse Y") * Move_SpeedV;

        moveHor *= Time.deltaTime;
        moveVert *= Time.deltaTime ;  

        Vector3 move = new Vector3 (moveHor, moveVert, 0.0f ) ;
        //P_rb.AddForce (move * Move_Speed) ;
        Player.transform.Translate(moveHor, moveVert, 0.0f) ;
    }
}
