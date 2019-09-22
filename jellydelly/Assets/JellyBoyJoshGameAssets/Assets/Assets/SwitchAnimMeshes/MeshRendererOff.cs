using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshRendererOff : MonoBehaviour
{
    SkinnedMeshRenderer skinnedMeshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        skinnedMeshRenderer = GameObject.Find("CubeVisuals").GetComponent<SkinnedMeshRenderer>();

    }

    void CubeSkinOff() {

        skinnedMeshRenderer = GameObject.Find("CubeVisuals").GetComponent<SkinnedMeshRenderer>();
        skinnedMeshRenderer.enabled = false;

    }
    void CubeSkinOn()
    {

        skinnedMeshRenderer = GameObject.Find("CubeVisuals").GetComponent<SkinnedMeshRenderer>();
        skinnedMeshRenderer.enabled = true;

    }
}
