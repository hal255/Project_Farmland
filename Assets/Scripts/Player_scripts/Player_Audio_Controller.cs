using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Audio_Controller : MonoBehaviour {
    Audio_Controller player_audio;

	// Use this for initialization
	void Start () {
        player_audio = gameObject.GetComponent<Audio_Controller>();
        AudioSource new_source = new AudioSource();
        new_source.clip = Resources.Load<AudioClip>("Audio/berserk_forces");
        //new_source.clip = Resources.Load("Audio/berserk_forces.mp3") as AudioClip;
        Debug.Log("Added Clip berserk_force as battle");
        player_audio.AddAudioSource("battle", new_source);
        player_audio.PlayAudio("battle");
	}
}
