using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GJ_PlayerCtrl : MonoBehaviour
{
	public GameObject Player ;
    public Text ScoreTxt;
    public GameObject ScoreObj;
    public int Score = 0;
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
    }

    // Update is called once per frame
    void Update()
    {
        P_Move () ;
        ScoreTxt.text = "SCORE: " + Score;
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
