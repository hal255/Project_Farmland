using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Audio_Controller : MonoBehaviour {
    private List<AudioClip> audio_clips;

	// Use this for initialization
	void Start () {
        audio_clips = new List<AudioClip>();
        AudioClip clip = Resources.Load("Audio/berserk_forces") as AudioClip;
        clip.name = "battle";
        audio_clips.Add(clip);
        foreach(AudioClip audio_clip in audio_clips)
        {
            if(audio_clip.name.Equals("battle"))
                AudioSource.PlayClipAtPoint(clip, gameObject.transform.position, 1.0f);
        }
	}
}
