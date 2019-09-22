using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleCharacter : MonoBehaviour
{
    public bool isCube = false;
    public AudioSource SoundSource;
    bool canPlay = true;

    public PlayerSwitcher playerSwitcher;
    // Start is called before the first frame update
    void Start()
    {
        SoundSource = this.GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().tag == "Player")
        {
            
            playerSwitcher.canSwitch = isCube;
            if (canPlay) {

                SoundSource.Play();
                canPlay = false;
            }
        }
     

    }
}
