using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwitcher : MonoBehaviour
{
    public bool canSwitch = true;

    public GameObject Cube;
    public GameObject CubeBody;

    //public Animator CubeAnimObj;



    public List<GameObject> Bones;

    //public Rigidbody fakeBallRb;

    bool isGavityEnabled;
    bool isGavityEnabled2;

    Animator anim;

    public GameObject SpawnedCube;

    Transform CubeTransform;
    Vector3 CubeVel;
    Vector3 SphereVel;

    //SkinnedMeshRenderer Rendy;

    public GameObject Sphere;

    public Cam cam;

    // Start is called before the first frame update
    void Awake()
    {
        Cube = GameObject.FindGameObjectWithTag("CubeHolder");
        CubeBody = GameObject.FindGameObjectWithTag("Player");
        //CubeAnimObj = GameObject.FindGameObjectWithTag("AnimForPlayer").GetComponent<Animator>();
        //Rendy = CubeBody.GetComponentInChildren<SkinnedMeshRenderer>();



        //cam.LookPos = Cube.transform;
        //cam.CurrentPlayer = Cube.transform;
    }

    // Update is called once per frame
    void Update()
    {


        Cube = GameObject.FindGameObjectWithTag("CubeHolder");
        CubeBody = GameObject.FindGameObjectWithTag("Player");
        //CubeAnimObj = GameObject.FindGameObjectWithTag("AnimForPlayer").GetComponent<Animator>();
        //Rendy = CubeBody.GetComponentInChildren<SkinnedMeshRenderer>();



        //print(Sphere.GetComponent<Rigidbody>().velocity);


        Bones = new List<GameObject>();
        Bones.AddRange(GameObject.FindGameObjectsWithTag("player"));

        if ((Input.GetKeyDown(KeyCode.Mouse0)) && (canSwitch == true))
        {

            //play switch from cube to sphere anim
            //Rendy.enabled = false;
            //CubeAnimObj.enabled = true;
            //run function
            Invoke("SwitchToSphere", 0f);


        }
        if ((Input.GetKeyUp(KeyCode.Mouse0)) && (canSwitch == true))
        {
            //play switch from sphere to cube anim
            //run function
            //CubeAnimObj.SetBool("isSwitched", true);
            //Invoke("resetAnim", 0.5f);

            Invoke("SwitchToCube", 0f);

        }
    }
    void FixedUpdate()
    {

    }
    void SwitchToSphere() {
        //Cube.SetActive(false);
        CubeTransform = CubeBody.transform;
        CubeVel = CubeBody.GetComponent<Rigidbody>().velocity;
        //isGavityEnabled = CubeBody.GetComponent<Rigidbody>().useGravity;
        if (CubeBody.GetComponent<Rigidbody>().useGravity == true)
        {
            isGavityEnabled = true;
        }
        if (CubeBody.GetComponent<Rigidbody>().useGravity == false)
        {
            isGavityEnabled = false;
        }

        Destroy(Cube);

        Sphere.SetActive(true);

        Sphere.transform.position = CubeTransform.position;
        Sphere.transform.rotation = CubeTransform.rotation;

        Sphere.GetComponent<Rigidbody>().velocity = CubeVel;

        if (isGavityEnabled == true)
        {
            Sphere.GetComponent<Rigidbody>().useGravity = true;
        }
        if (isGavityEnabled == false)
        {
            Sphere.GetComponent<Rigidbody>().useGravity = true;
        }

        //cam.LookPos = Sphere.transform;
        //cam.CurrentPlayer = Sphere.transform;

    }
    void SwitchToCube()
    {
        if (Sphere.GetComponent<Rigidbody>().useGravity == true)
        {
            isGavityEnabled2 = true;
        }
        if (Sphere.GetComponent<Rigidbody>().useGravity == false)
        {
            isGavityEnabled2 = false;
        }

        CubeBody = Sphere;
        SphereVel = Sphere.GetComponent<Rigidbody>().velocity;
        Instantiate(SpawnedCube, Sphere.transform.position, Sphere.transform.rotation);
        CubeBody = GameObject.Find("Body");
        print(CubeBody);

        if (isGavityEnabled2 == true)
        {
            CubeBody.GetComponent<Rigidbody>().useGravity = true;
        }
        if (isGavityEnabled2 == false)
        {
            CubeBody.GetComponent<Rigidbody>().useGravity = true;
        }


        CubeBody.GetComponent<Rigidbody>().velocity = SphereVel;

        Bones = new List<GameObject>();
        Bones.AddRange(GameObject.FindGameObjectsWithTag("player"));
        foreach (GameObject bone in Bones)
        {

            bone.GetComponent<Rigidbody>().velocity = SphereVel;

        }
        Sphere.SetActive(false);



        //Cube.transform.position = Sphere.transform.position;


        //cam.LookPos = Cube.transform;
        //cam.CurrentPlayer = Cube.transform;

    }
    //void resetAnim() {

    //    CubeAnimObj.SetBool("isSwitched", false);


    //}
}
