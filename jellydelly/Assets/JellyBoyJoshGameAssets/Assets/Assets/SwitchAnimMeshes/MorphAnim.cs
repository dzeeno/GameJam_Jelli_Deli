using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MorphAnim : MonoBehaviour
{
    public Animator anim;
    public PlayerSwitcher playerSwitcher;

    public AudioSource SoundSource;
    public AudioClip SoundClip;
    public AudioSource SoundSource2;
    public AudioClip SoundClip2;

    public float minPitch, maxPitch;

    //public Transform sphere;
    //public Transform cube;
    //SkinnedMeshRenderer skinnedMeshRenderer;

    // Start is called before the first frame update
    private void Awake()
    {
        SoundSource = GetComponents<AudioSource>()[0];
        SoundSource.clip = SoundClip;
        SoundSource2 = GetComponents<AudioSource>()[1];
        SoundSource2.clip = SoundClip2;
    }
    void Start()
    {
        //cube = GameObject.FindGameObjectWithTag("Player").transform;
        anim.SetBool("isSwitched", true);

        //skinnedMeshRenderer = GameObject.Find("CubeVisuals").GetComponent<SkinnedMeshRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        //cube = GameObject.FindGameObjectWithTag("Player").transform;

        //skinnedMeshRenderer = GameObject.Find("CubeVisuals").GetComponent<SkinnedMeshRenderer>();

        if ((Input.GetKeyDown(KeyCode.Mouse0)) && (playerSwitcher.canSwitch == true)) {


            //transform.position = sphere.transform.position;
            //transform.rotation = sphere.transform.rotation;

            //transform.SetParent(sphere);
            //skinnedMeshRenderer.enabled = false;
           
          
            anim.SetBool("isSwitched", false);
            SoundSource.pitch = Random.Range(minPitch, maxPitch);
            SoundSource.Play();

        }
        if ((Input.GetKeyUp(KeyCode.Mouse0)) && (playerSwitcher.canSwitch == true))
            {
            //transform.position = cube.transform.position;
            //transform.rotation = cube.transform.rotation;
            //transform.SetParent(cube);
         

            anim.SetBool("isSwitched", true);
            SoundSource2.pitch = Random.Range(minPitch, maxPitch);
            SoundSource2.Play();

        }
    }
}
