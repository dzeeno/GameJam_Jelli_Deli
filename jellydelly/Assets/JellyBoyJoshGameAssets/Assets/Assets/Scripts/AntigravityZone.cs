using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntigravityZone : MonoBehaviour {

    public bool canAddForce;

    public float EnterDirection;
    public float EnterDirectionX;

    public AudioSource SoundSource;
    public AudioClip SoundClip;

    public float minPitch, maxPitch;


    // Use this for initialization
    void Awake () {

        SoundSource = this.GetComponent<AudioSource>();
        SoundSource.clip = SoundClip;
    }
    private void Start()
    {
        SoundSource.Play();
    }

    private void OnTriggerStay(Collider other)
    {
        if ((other.GetComponent<Collider>().tag == "Player") || (other.GetComponent<Collider>().tag == "player")) {

            other.GetComponent<Rigidbody>().useGravity = false;
            other.GetComponent<Rigidbody>().velocity = Vector3.zero;
       
            if (canAddForce)
            {
               
                other.GetComponent<Rigidbody>().AddForce(EnterDirectionX, EnterDirection, 0f);
            }



        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if ((other.GetComponent<Collider>().tag == "Player") || (other.GetComponent<Collider>().tag == "player"))
        {
            if (canAddForce)
            {

            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if ((other.GetComponent<Collider>().tag == "Player") || (other.GetComponent<Collider>().tag == "player"))
        {
            //Invoke("StopPlaying", 0.1f);
            other.GetComponent<Rigidbody>().useGravity = true;

        }
    }

    //void StopPlaying() {

    //    SoundSource.Stop();

    //}
}
