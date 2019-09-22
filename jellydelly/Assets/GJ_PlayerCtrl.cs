using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GJ_PlayerCtrl : MonoBehaviour
{
	public GameObject Player ;
    //public float smoothing = 2.0f;

    //private Vector2 M_look;
    //private Vector2 smoothV;
    private float Move_Speed = 10f;
    private float moveHor ;
    private float moveVert ;

    // Start is called before the first frame update
    void Start()
    {
        Player = this.gameObject ;
        Cursor.visible = false ;
    }

    // Update is called once per frame
    void Update()
    {
        P_Move () ;  
    }

    private void P_Move()
    {
        float moveHor = Input.GetAxis("Mouse X") * Move_Speed;
        float moveVert = Input.GetAxis("Mouse Y") * Move_Speed;

        moveHor *= Time.deltaTime;
        moveVert *= Time.deltaTime ;  

        Vector3 move = new Vector3 (moveHor, moveVert, 0.0f ) ;
        //P_rb.AddForce (move * Move_Speed) ;
        Player.transform.Translate(moveHor, moveVert, 0.0f) ;
    }
}
