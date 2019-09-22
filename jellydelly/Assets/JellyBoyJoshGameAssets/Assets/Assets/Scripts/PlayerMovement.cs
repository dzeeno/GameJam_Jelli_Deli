using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour{

    Rigidbody rb;
    //public GameObject player;
    public float speed;
    Animator anim;
    float CurrentSpeed;
    public float sprintSpeed;
    float normalSpeed;
    public float jumpForceOnGround;
    public float jumpForceOnWall;

    public GameObject Sphere;

    public Cam cam;

    public float fallMult;

    float coolDownTimer;
    public float coolDownTimerAmount;

    float m_jumpForce;


    public float dampening = 150f;
    Vector3 Velocity = Vector3.zero;

    public AudioSource SoundSource;
    public AudioClip SoundClip;
    public AudioSource SoundSource2;
    public AudioClip SoundClip2;
    public AudioSource SoundSource3;
    public AudioClip SoundClip3;

    public AudioSource SoundSource4;
    public AudioClip SoundClip4;

    public float minPitch, maxPitch;

    public int soundNumber;

    //bool JumpWallTimer = false;

    //float JumpWallCounter = 0f;

    bool isGrounded;

    bool isOnLeftWall;

    bool isOnRightWall;

    // Start is called before the first frame update
    void Awake()
    {
        anim = GetComponentInChildren<Animator>();
        rb = GetComponent<Rigidbody>();
        Sphere = GameObject.Find("SphereCharacter 1");
        cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Cam>();

        SoundSource = GameObject.FindGameObjectWithTag("SoundObject").GetComponents<AudioSource>()[0];
        SoundSource.clip = SoundClip;
        SoundSource2 = GameObject.FindGameObjectWithTag("SoundObject").GetComponents<AudioSource>()[1];
        SoundSource2.clip = SoundClip2;
        SoundSource3 = GameObject.FindGameObjectWithTag("SoundObject").GetComponents<AudioSource>()[2];
        SoundSource3.clip = SoundClip3;
        SoundSource4 = GameObject.FindGameObjectWithTag("SoundObject").GetComponents<AudioSource>()[3];
        SoundSource4.clip = SoundClip4;



        //rb.velocity = Sphere.GetComponent<Rigidbody>().velocity;

    }
    private void Start()
    {
        normalSpeed = speed;


    }
    void Update()
    {
    

        if (coolDownTimer > 0) {
            coolDownTimer -= Time.deltaTime;
        }
        if (coolDownTimer <= 0) {
            coolDownTimer = 0;
        }
        SoundSource = GameObject.FindGameObjectWithTag("SoundObject").GetComponents<AudioSource>()[0];
        SoundSource.clip = SoundClip;
        SoundSource2 = GameObject.FindGameObjectWithTag("SoundObject").GetComponents<AudioSource>()[1];
        SoundSource2.clip = SoundClip2;
        SoundSource3 = GameObject.FindGameObjectWithTag("SoundObject").GetComponents<AudioSource>()[2];
        SoundSource3.clip = SoundClip3;
        SoundSource4 = GameObject.FindGameObjectWithTag("SoundObject").GetComponents<AudioSource>()[3];
        SoundSource4.clip = SoundClip4;

    }
    void FixedUpdate()
    {
        playerMovement();

        if (isGrounded)
        {

            if ((Input.GetKeyDown(KeyCode.Space)) /*&& (coolDownTimer == 0)*/)
            {
                cam.Smoothing = 15f;
                //Invoke("ColliderOff", 0.5f);
                //Invoke("ColliderOn", 2f);
                //JumpWallTimer = true;
                rb.AddForce(new Vector3(0f, 1200f * m_jumpForce, 0f), ForceMode.Acceleration);
                //coolDownTimer = coolDownTimerAmount;
                //rb.transform.position = Vector3.Lerp(rb.transform.position, rb.transform.position + new Vector3(-10f, 0f, 0f), dampening * Time.deltaTime);
            }
        }
        if (isOnLeftWall)
        {
            //speed = 8f;
            if ((Input.GetKeyDown(KeyCode.Space)) && (coolDownTimer == 0))
            {
                cam.Smoothing = 35f;
                //Invoke("ColliderOff", 0.5f);
                //Invoke("ColliderOn", 2f);


                rb.AddForce(new Vector3(-1200f * m_jumpForce, 1200f * m_jumpForce, 0f), ForceMode.Acceleration);
                coolDownTimer = coolDownTimerAmount;

                SoundSource.pitch = Random.Range(minPitch, maxPitch);
                SoundSource.Play();
                SoundSource2.pitch = Random.Range(minPitch, maxPitch);
                SoundSource2.Play();
                SoundSource3.pitch = Random.Range(minPitch, maxPitch);
                SoundSource3.Play();
                SoundSource4.pitch = Random.Range(minPitch, maxPitch);
                SoundSource4.Play();

            }
        }
        if (isOnRightWall)
        {
            //speed = 3f;
            if ((Input.GetKeyDown(KeyCode.Space)) && (coolDownTimer == 0))
            {
                cam.Smoothing = 35f;
                //Invoke("ColliderOff", 0.5f);
                //Invoke("ColliderOn", 2f);


                rb.AddForce(new Vector3(1200f * m_jumpForce, 1200f * m_jumpForce, 0f), ForceMode.Acceleration);
                coolDownTimer = coolDownTimerAmount;
                SoundSource.pitch = Random.Range(minPitch, maxPitch);
                SoundSource.Play();
                SoundSource2.pitch = Random.Range(minPitch, maxPitch);
                SoundSource2.Play();
                SoundSource3.pitch = Random.Range(minPitch, maxPitch);
                SoundSource3.Play();
                SoundSource4.pitch = Random.Range(minPitch, maxPitch);
                SoundSource4.Play();
            }
        }

        //if (JumpWallTimer) {
        //    JumpWallCounter += Time.deltaTime;
        //}
        //if (JumpWallCounter >= 3f) {
        //    JumpWallCounter = 0f;
        //    JumpWallTimer = false;
        //}
        if ((rb.velocity.y < 0) && (isGrounded == false))
        {

            rb.velocity += Vector3.up * Physics.gravity.y * (fallMult - 1) * Time.deltaTime;

        }
        //if (isOnLeftWall)
        //{
        //    if (Input.GetKeyDown(KeyCode.Space))
        //    {
        //        rb.AddForce(new Vector3(-350000f, 50000f * jumpforce, 0f));
        //    }
        //}
        //if (isOnRightWall)
        //{
        //    if (Input.GetKeyDown(KeyCode.Space))
        //    {
        //        rb.AddForce(new Vector3(350000f, 50000f * jumpforce, 0f));
        //    }
        //}
    }

    // Update is called once per frame

   
    void playerMovement()
    {

        rb.velocity = new Vector3(Input.GetAxis("Horizontal") * speed, rb.velocity.y, /*Input.GetAxis("Vertical") * speed*/ rb.velocity.z);
        transform.position = this.transform.position;

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = sprintSpeed;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = normalSpeed;
        }
        //if (Input.GetKeyDown(KeyCode.A)){
        //    rb.constraints = RigidbodyConstraints.None;
        //    rb.constraints = RigidbodyConstraints.FreezePositionZ;
        //}
        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    rb.constraints = RigidbodyConstraints.None;
        //    rb.constraints = RigidbodyConstraints.FreezePositionZ;
        //}
        //if (Input.GetKeyDown(KeyCode.S))
        //{
        //    rb.constraints = RigidbodyConstraints.None;
        //    rb.constraints = RigidbodyConstraints.FreezePositionX;
        //}
        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    rb.constraints = RigidbodyConstraints.None;
        //    rb.constraints = RigidbodyConstraints.FreezePositionX;
        //}
        //if (Input.GetAxis("Horizontal") == 0)
        //{

        //    rb.angularVelocity = Vector3.zero;
        //}
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().tag == "TopWall")
        {
            SoundSource.pitch = Random.Range(minPitch, maxPitch);
            SoundSource.Play();
            SoundSource2.pitch = Random.Range(minPitch, maxPitch);
            SoundSource2.Play();
            SoundSource3.pitch = Random.Range(minPitch, maxPitch);
            SoundSource3.Play();

            m_jumpForce = jumpForceOnGround;
            isGrounded = true;
        }
        if (other.GetComponent<Collider>().tag == "LeftWall")
        {
            SoundSource.pitch = Random.Range(minPitch, maxPitch);
            SoundSource.Play();
            SoundSource2.pitch = Random.Range(minPitch, maxPitch);
            SoundSource2.Play();
            SoundSource3.pitch = Random.Range(minPitch, maxPitch);
            SoundSource3.Play();
            m_jumpForce = jumpForceOnWall;
            isOnLeftWall = true;
        }
        if (other.GetComponent<Collider>().tag == "RightWall")
        {
            SoundSource.pitch = Random.Range(minPitch, maxPitch);
            SoundSource.Play();
            SoundSource2.pitch = Random.Range(minPitch, maxPitch);
            SoundSource2.Play();
            SoundSource3.pitch = Random.Range(minPitch, maxPitch);
            SoundSource3.Play();
            m_jumpForce = jumpForceOnWall;
            isOnRightWall = true;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<Collider>().tag == "TopWall")
        {
            m_jumpForce = jumpForceOnGround;
            isGrounded = true;
        }
        if (other.GetComponent<Collider>().tag == "LeftWall")
        {
            m_jumpForce = jumpForceOnWall;
            isOnLeftWall = true;
        }
        if (other.GetComponent<Collider>().tag == "RightWall")
        {
            m_jumpForce = jumpForceOnWall;
            isOnRightWall = true;
        }


    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Collider>().tag == "TopWall")
        {
            isGrounded = false;
        }
        if (other.GetComponent<Collider>().tag == "LeftWall")
        {
            isOnLeftWall = false;
            isGrounded = false;
        }
        if (other.GetComponent<Collider>().tag == "RightWall")
        {
            isOnRightWall = false;
            isGrounded = false;
        }
    }
    void ColliderOff()
    {
        this.GetComponent<BoxCollider>().enabled = false;
    }
    void ColliderOn() {
        this.GetComponent<BoxCollider>().enabled = true;
    }

}
