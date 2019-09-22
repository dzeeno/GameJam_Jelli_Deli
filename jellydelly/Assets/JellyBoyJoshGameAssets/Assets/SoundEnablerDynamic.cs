using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEnablerDynamic : MonoBehaviour {

    public AudioSource SoundSource;
    public AudioClip SoundClip;

    public AudioClip SoundClip2;


    public string SoundObjectName;

    // Use this for initialization
    void Start()
    {

        SoundSource = GameObject.Find(SoundObjectName).GetComponent<AudioSource>();

        SoundSource.clip = SoundClip;
        

        //OldSong = GameObject.Find(SoundObjectName).GetComponents<AudioSource>()[0];
        //OldSong.clip = OldSongClip;

        //NewSong = GameObject.Find(SoundObjectName).GetComponents<AudioSource>()[1];
        //NewSong.clip = NewSongClip;
        //OldSong.Play();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.M))
        {

            SoundSource.Stop();
            SoundSource.clip = SoundClip2;
            SoundSource.Play();



            //OldSong.mute = true;
            //OldSong.enabled = false;
            //NewSong.enabled = true;
            //NewSong.Play();
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().tag == "Ship")
        {
            SoundSource.Stop();
            SoundSource.clip = SoundClip2;
            SoundSource.Play();

            //OldSong.Stop();
            //OldSong.enabled = false;
            //NewSong.enabled = true;
            //NewSong.Play();

        }
    }
}
