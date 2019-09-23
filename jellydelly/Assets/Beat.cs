using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Beat : MonoBehaviour
{
    public float BeatSpeed = 5f;
<<<<<<< HEAD
    public GameObject sparks;
=======
    public int Score = 0;
    public GameObject Player ;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("UFO_ForGameJam");
    }
>>>>>>> 872c6a814291a5403ed69e682c0011907983c9f4

    // Update is called once per frame
    void FixedUpdate()
    {

        transform.Translate(BeatSpeed * Time.deltaTime, 0f, 0f);

    }
    private void OnCollisionEnter(Collision Other)
    {
        if (Other.collider.tag == "Player")
        {
<<<<<<< HEAD
            Instantiate(sparks, this.transform.position, this.transform.rotation);
=======
            Score += 10 ;
            Player.GetComponent<GJ_PlayerCtrl>().Score += Score;
>>>>>>> 872c6a814291a5403ed69e682c0011907983c9f4
            Destroy(this.gameObject, 0f);
        }
    }
}