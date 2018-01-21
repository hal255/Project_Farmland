using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pong_Ball_Motion : MonoBehaviour {
    [SerializeField]
    float move_speed = 10.0f;               // velocity of ball
    private float rotate_angle = 0.0f;      // angle of ball, from top down view

    float added_speed = 0.0f;               // added speed from user's paddle

	// Use this for initialization
	void Start () {
        // generate a random angle and move towards that direction
        float new_angle = Random.value * 359;
        transform.Rotate(Vector3.up * new_angle);       // "up" is the y-axis, the top-down view

	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * move_speed * Time.deltaTime);
	}
}
