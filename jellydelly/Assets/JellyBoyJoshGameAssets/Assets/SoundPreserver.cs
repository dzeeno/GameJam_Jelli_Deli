using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPreserver : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    private static SoundPreserver instance = null;
    public static SoundPreserver Instance {
        get { return instance; }
    }
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
