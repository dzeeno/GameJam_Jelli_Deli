using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecalSpawner : MonoBehaviour
{
    public GameObject SlimeDecal;
    float random;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if((collision.gameObject.tag != "Player") || (collision.gameObject.tag != "player")){
            random = Random.Range(0f, 360f);
            Instantiate(SlimeDecal, this.transform.position, Quaternion.Euler(-90f, 0f, random));
        }
    }
}
