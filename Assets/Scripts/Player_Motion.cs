using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Motion : MonoBehaviour {
    private Gravity player_gravity;
    private My_Debug_Logs debug_logs;
    private CapsuleCollider player_collider;

	// Use this for initialization
	void Start () {
        // associate player character with it's components
        debug_logs = gameObject.GetComponent<My_Debug_Logs>();
        player_gravity = gameObject.GetComponent<Gravity>();
        player_collider = gameObject.GetComponent<CapsuleCollider>();

        // set player gravity and add to debug message
        set_player_gravity(-1.0f);
	}
	
	// Update is called once per frame
	void Update () {
        // print debug messages
        debug_logs.print_messages();

        // check if player is collided with ground
    }

    void set_player_gravity(float speed)
    {
        player_gravity.set_gravity(-1.0f);
        debug_logs.add_message("player_gravity", speed + "");
    }

    void handle_floor_collision(Collider other)
    {
        set_player_gravity(0.0f);
        debug_logs.add_message("player_vertical_collision", other.gameObject.name);
    }

}
