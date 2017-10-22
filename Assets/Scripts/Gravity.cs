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

    // set value of gravity
    void set_gravity(float speed)
    {
        gravity = speed;
    }

    // return gravity speed
    float get_gravity()
    {
        return gravity;
    }

    // toggle is_grounded
    void toggle_grounded()
    {
        if (is_grounded)
            is_grounded = false;
        else
            is_grounded = true;
    }
}
