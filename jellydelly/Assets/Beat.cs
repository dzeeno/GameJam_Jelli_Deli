using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beat : MonoBehaviour
{
    public float BeatSpeed = 5f;
    public GameObject sparks;

    // Update is called once per frame
    void FixedUpdate()
    {

        transform.Translate(BeatSpeed * Time.deltaTime, 0f, 0f);

    }
    private void OnCollisionEnter(Collision Other)
    {
        if (Other.collider.tag == "Player")
        {
            Instantiate(sparks, this.transform.position, this.transform.rotation);
            Destroy(this.gameObject, 0f);
        }
    }
}