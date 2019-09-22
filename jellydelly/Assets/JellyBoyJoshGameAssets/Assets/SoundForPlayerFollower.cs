using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundForPlayerFollower : MonoBehaviour
{

    public AudioSource SoundSource;
    public AudioClip SoundClip;

    //public AudioSource SoundSource2;
    //public AudioClip SoundClip2;

    //public AudioSource SoundSource3;
    //public AudioClip SoundClip3;

    public float minPitch, maxPitch;

    public int soundNumber;

    //public int soundNumber2;
    //public int soundNumber3;

    GameObject player;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        SoundSource = GameObject.FindGameObjectWithTag("SoundObject").GetComponent<AudioSource>();
        SoundSource.clip = SoundClip;

        //SoundSource2 = GameObject.Find("SoundObject").GetComponents<AudioSource>()[soundNumber2];
        //SoundSource2.clip = SoundClip2;

        //SoundSource3 = GameObject.Find("SoundObject").GetComponents<AudioSource>()[soundNumber3];
        //SoundSource3.clip = SoundClip3;
    }

    private void Update()
    {
        
        player = GameObject.FindGameObjectWithTag("Player");

        transform.position = player.transform.position;
        transform.rotation = player.transform.rotation;
    }
  
    private void OnTriggerEnter(Collider other)
    {
        if ((other.GetComponent<Collider>().tag == "TopWall"))

        {
            SoundSource.pitch = Random.Range(minPitch, maxPitch);
            SoundSource.Play();
        }
    }
   
}