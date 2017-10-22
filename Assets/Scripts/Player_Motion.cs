using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Motion : MonoBehaviour {
    private Gravity player_gravity;
    private My_Debug_Logs debug_logs;

	// Use this for initialization
	void Start () {
        // associate player character with it's components
        debug_logs = gameObject.GetComponent<My_Debug_Logs>();
        player_gravity = gameObject.GetComponent<Gravity>();

        // set player gravity and add to debug message
        set_player_gravity(-1.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void set_player_gravity(float speed)
    {
        player_gravity.set_gravity(-1.0f);
        debug_logs.add_message("player_gravity", speed + "");
    }
}
