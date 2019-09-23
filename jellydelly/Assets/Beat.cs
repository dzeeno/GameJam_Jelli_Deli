using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beat : MonoBehaviour
{
    public float BeatSpeed = 5f;
    public GameObject sparks;
    public int Score = 0;
    public GameObject Player;
    public Animator anim;



    void Start()
    {
        Player = GameObject.Find("UFO_ForGameJam");
    }
    // Update is called once per frame
    void FixedUpdate()
    {

        transform.Translate(BeatSpeed * Time.deltaTime, 0f, 0f);

    }
    private void OnCollisionEnter(Collision Other)
    {
        if (Other.collider.tag == "Player")
        {
            Score += 10;
            anim.SetBool("isHit", true);
            Player.GetComponent<GJ_PlayerCtrl>().Hit = true;
            Player.GetComponent<GJ_PlayerCtrl>().Score += Score;
            Player.GetComponent<GJ_PlayerCtrl>().hasAnimated = true;
            Instantiate(sparks, this.transform.position, this.transform.rotation);
            Destroy(this.gameObject, 0f);
        }
    }
}