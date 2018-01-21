using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pong_Ball_Motion : MonoBehaviour {
    [SerializeField]
    float move_speed = 10.0f;
    private float rotate_angle = 0.0f;

	// Use this for initialization
	void Start () {
        float new_angle = Random.value * 369;
        transform.Rotate(Vector3.up * new_angle);

	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * move_speed * Time.deltaTime);
	}
}
