using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class resetlvl : MonoBehaviour {

    GameObject Player;
    public GameObject ResetPos;
    public AudioSource SoundSource;
    bool canPlay = true;

    //public int currentSceneNumber;

    // Use this for initialization
    void Start () {
        SoundSource = this.GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update () {

        Player = GameObject.FindGameObjectWithTag("Player");

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Player.transform.position = ResetPos.transform.position;
            Player.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);

            //SceneManager.LoadScene(0);

        }
        //if (Input.GetKeyDown(KeyCode.R))
        //{
        //    //Player.transform.position = ResetPos.transform.position;
        //    //Player.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);

        //    SceneManager.LoadSceneAsync(0);

        //}
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().tag == "Player") {

            if (canPlay)
            {
                SoundSource.Play();
                canPlay = false;
            }
            Invoke("reset", 4f);
          

            //SceneManager.LoadScene(currentSceneNumber);

        }
    }
    void reset() {

        Player.transform.position = ResetPos.transform.position;
        Player.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);

    }
}
