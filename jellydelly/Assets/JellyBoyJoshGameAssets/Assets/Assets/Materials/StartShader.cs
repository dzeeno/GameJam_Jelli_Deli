using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartShader : MonoBehaviour
{
    public Material mat;
    //public float Current;
    public float Max;

    // Start is called before the first frame update
    void Start()
    {
        mat.SetFloat("Vector1_5E52B312", Max);
    }

    // Update is called once per frame
    void Update()
    {

        mat.SetFloat("Vector1_5E52B312", Max);

    }
}
