using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IECubemovement : MonoBehaviour {

    Vector3 offset;

    public Rigidbody player;

    public GameObject center;

    public GameObject up;
    public GameObject down;
    public GameObject left;
    public GameObject right;

    public int step = 9;

    public float speed = (float)0.01;

    bool input = true;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (input == true) {
            if (Input.GetKey(KeyCode.W)) {
                StartCoroutine("MoveUp");
                input = false;
            }
            if (Input.GetKey(KeyCode.S))
            {
                StartCoroutine("MoveDown");
                input = false;
            }
            if (Input.GetKey(KeyCode.A))
            {
                StartCoroutine("MoveLeft");
                input = false;
            }
            if (Input.GetKey(KeyCode.D))
            {
                StartCoroutine("MoveRight");
                input = false;
            }
        }

	}

    IEnumerator MoveUp() {
        for (int i = 0; i < (90 / step); i++) {
            player.transform.RotateAround(up.transform.position, Vector3.right, step);
                yield return new WaitForSeconds(speed);
        }
        center.transform.position = player.transform.position;
        input = true;

    }
    IEnumerator MoveDown()
    {
        for (int i = 0; i < (90 / step); i++)
        {
            player.transform.RotateAround(down.transform.position, Vector3.left, step);
            yield return new WaitForSeconds(speed);
        }
        center.transform.position = player.transform.position;
        input = true;

    }
    IEnumerator MoveLeft()
    {
        for (int i = 0; i < (90 / step); i++)
        {
            player.transform.RotateAround(left.transform.position, Vector3.forward, step);
            yield return new WaitForSeconds(speed);
        }
        center.transform.position = player.transform.position;
        input = true;

    }
    IEnumerator MoveRight()
    {
        for (int i = 0; i < (90 / step); i++)
        {
            player.transform.RotateAround(right.transform.position, Vector3.back, step);
            yield return new WaitForSeconds(speed);
        }
        center.transform.position = player.transform.position;
        input = true;
    }
}
