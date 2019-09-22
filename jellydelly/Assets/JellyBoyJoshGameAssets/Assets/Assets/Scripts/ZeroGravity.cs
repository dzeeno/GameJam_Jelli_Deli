using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeroGravity : MonoBehaviour {

    public AudioSource SoundSource;
    public AudioClip SoundClip;
    public bool canPlay = true;
    public float minPitch, maxPitch;


    // Use this for initialization
    void Awake()
    {
        SoundSource = GameObject.FindGameObjectWithTag("SoundZeroGravity").GetComponent<AudioSource>();
        SoundSource.clip = SoundClip;
    }

    private void OnTriggerEnter(Collider other)
    {
        if ((other.GetComponent<Collider>().tag == "Player") || (other.GetComponent<Collider>().tag == "player"))
        {

            other.GetComponent<Rigidbody>().useGravity = false;
            if (canPlay){

                SoundSource.pitch = Random.Range(minPitch, maxPitch);
                SoundSource.Play();
            }
            //other.GetComponent<Rigidbody>().velocity = Vector3.zero;


        }
    }
    private void OnTriggerExit(Collider other)
    {
        if ((other.GetComponent<Collider>().tag == "Player") || (other.GetComponent<Collider>().tag == "player"))
        {

            other.GetComponent<Rigidbody>().useGravity = true;
            SoundSource.Stop();


        }
    }
}
