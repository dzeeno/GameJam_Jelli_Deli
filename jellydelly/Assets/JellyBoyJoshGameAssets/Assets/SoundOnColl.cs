using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnColl : MonoBehaviour {

    public AudioSource SoundSource;
    public AudioClip SoundClip;

    // Use this for initialization
    void Start () {

        SoundSource = GetComponent<AudioSource>();

        SoundSource.clip = SoundClip;

        SoundSource.pitch = Random.Range(1f, 1.2f);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().tag == "player")
        {
            SoundSource.PlayOneShot(SoundClip);
        }

    }
}
