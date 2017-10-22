using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour {
    private float gravity = -9.8f;
    private bool is_grounded = false;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!is_grounded)
        {
            transform.Translate(Vector3.up * gravity * Time.deltaTime);
        }
    }

}
