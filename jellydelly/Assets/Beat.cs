using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Beat : MonoBehaviour
{
    public float BeatSpeed = 5f;
    public int Score = 0;
    public GameObject Player ;

    // Start is called before the first frame update
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
            Score += 10 ;
            Player.GetComponent<GJ_PlayerCtrl>().Score += Score;
            Destroy(this.gameObject, 0f);
        }
    }
}