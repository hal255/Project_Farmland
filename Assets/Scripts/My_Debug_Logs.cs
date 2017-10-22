using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class My_Debug_Logs : MonoBehaviour {
    private bool debug = true;
    private Dictionary<string, string> debug_messages = new Dictionary<string, string>();

    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        // if in debug mode, then print all debug messages
		if (debug)
        {
            foreach(string s in debug_messages.Keys)
                Debug.Log(debug_messages[s]);
        }
	}

    // add new message to debug message logs
    public void add_message(string key, string value)
    {
        if (!debug_messages.ContainsKey(key))
        {
            debug_messages.Add(key, value);
        }
        else
            debug_messages[key] = value;
    }

    // toggle display debug messages
    public void toggle_debug()
    {
        // shorthand if statement
        // if debug is true, set it to false, else set debug true
        debug = debug ? false : true;
    }
}
