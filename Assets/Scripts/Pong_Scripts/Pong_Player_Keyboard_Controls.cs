using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pong_Player_Keyboard_Controls : MonoBehaviour {

    [SerializeField]
    float move_speed = 1.0f;

    private float modifier = 1.0f;
    private bool isPlayer01 = true;

    // Use this for initialization
    void Start () {
        if (gameObject.name.Contains("02"))
        {
            modifier *= -1;
            isPlayer01 = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) && isPlayer01)
        {
            Debug.Log("Pressed player1 left key.");
            moveLeft();
        }

        if (Input.GetKey(KeyCode.D) && isPlayer01)
        {
            Debug.Log("Pressed player1 right key.");
            moveRight();
        }

        if (Input.GetKey(KeyCode.J) && !isPlayer01)
        {
            Debug.Log("Pressed player2 left key.");
            moveLeft();
        }

        if (Input.GetKey(KeyCode.L) && !isPlayer01)
        {
            Debug.Log("Pressed player2 right key.");
            moveRight();
        }

    }

    private void moveLeft()
    {
        transform.Translate(Vector3.forward * move_speed * -1.0f * modifier * Time.deltaTime);
    }
    private void moveRight()
    {
        transform.Translate(Vector3.forward * move_speed * modifier * Time.deltaTime);
    }

}
