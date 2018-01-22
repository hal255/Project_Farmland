using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pong_Ball_Motion : MonoBehaviour {
    private bool debug = true;

    [SerializeField]
    float move_speed = 10.0f;               // velocity of ball
    private float rotate_angle = 0.0f;      // angle of ball, from top down view

    //float added_speed = 0.0f;               // added speed from user's paddle

	// Use this for initialization
	void Start () {
        // generate a random angle and move towards that direction
        rotate_angle = GetNewAngle(0);
        SetBallRotation();
    }

    // Update is called once per frame
    void Update () {
        transform.Translate(Vector3.forward * move_speed * Time.deltaTime);
	}

    float GetNewAngle(float angle)
    {
        angle = Random.value * 359;
        if ((angle >= 25f && angle <= 155f) || (angle >= 205f && angle <= 335f))
            return angle;
        else
            return GetNewAngle(angle);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (debug)
            Debug.Log("Colision detected!!!!!!!! Pong ball current angle: " + rotate_angle);
        rotate_angle = (rotate_angle > 180f) ? rotate_angle - 180f : rotate_angle + 180f;
        SetBallRotation();
    }

    void SetBallRotation()
    {
        transform.Rotate(Vector3.up * rotate_angle);       // "up" is the y-axis, the top-down view
        if (debug)
            Debug.Log("Pong ball new angle: " + rotate_angle);
    }
}
