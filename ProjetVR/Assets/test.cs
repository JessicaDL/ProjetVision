using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

    public AudioSource son;

	// Use this for initialization
	void Start () {
        son.Play();
    }
	
	// Update is called once per frame
	void Update () {
        if(son.time > 5.0f)
        {
            son.Stop();
        }

	}
}
