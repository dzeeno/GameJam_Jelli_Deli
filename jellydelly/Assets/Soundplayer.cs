using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundplayer : MonoBehaviour
{
    public AudioSource audioS;
    //public AudioSource audio3;

    public GameObject audio2;
    public bool play2;
    public Animator anim;
  

    public playermover Playermover;
    // Start is called before the first frame update

    private void Start()
    {
        audioS.GetComponent<AudioSource>();

        Invoke("playSound", 3f);
    }
    private void Update()
    {
        if (Playermover.isAtPos2 == true) {
            play2 = true;
        }
        if (play2) {
            audio2.SetActive(true);
            Invoke("stopAnim", 19f);
            print("www");
            play2 = false;
        }
    }

    void playSound() {
        audioS.Play();
    }
    void stopAnim() {
        anim.enabled = false;
        Playermover.CurrentPos = Playermover.pos3;
    }



}
