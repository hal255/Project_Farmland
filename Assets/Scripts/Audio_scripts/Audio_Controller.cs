using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Controller : MonoBehaviour {
    private Dictionary<string, AudioSource> audiosource_map;

	// Use this for initialization
	void Start () {
        audiosource_map = new Dictionary<string, AudioSource>();
    }
	
    public void AddAudioSource(string audio_name, AudioSource source)
    {
        Debug.Log("Added " + audio_name);
        audiosource_map.Add(audio_name, source);
    }

    // if audio_name is in list, then change volume
    public void ChangeVolume(string audio_name, float volume)
    {
        if (audiosource_map[audio_name] != null)
            audiosource_map[audio_name].volume = volume;
    }

    // if audio_name is in list, and is not playing, then play audio
    public void PlayAudio(string audio_name)
    {
        if (audiosource_map[audio_name] != null)
            if (!audiosource_map[audio_name].isPlaying)
                audiosource_map[audio_name].Play();
    }

    // if audio_name is in list, and is playing, then stop playing audio
    public void StopAudio(string audio_name)
    {
        if (audiosource_map[audio_name] != null)
            if (audiosource_map[audio_name].isPlaying)
                audiosource_map[audio_name].Stop();
    }
}
