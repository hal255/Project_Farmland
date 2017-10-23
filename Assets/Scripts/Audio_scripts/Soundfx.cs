using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundfx : MonoBehaviour {
    AudioSource audio_source;

    // Use this for initialization
    void Start()
    {

    }

    // plays sound on demand
    void play_sound()
    {
        if (audio_source == null)
        {
            gameObject.GetComponent<My_Debug_Logs>().add_message(gameObject.name + " soundfx failed", "No source");
            return;
        }

        if (!audio_source.isPlaying)
        {
            gameObject.GetComponent<My_Debug_Logs>().add_message(gameObject.name + " soundfx", "is playing " + audio_source.name);
            audio_source.Play();
        }
    }


}
