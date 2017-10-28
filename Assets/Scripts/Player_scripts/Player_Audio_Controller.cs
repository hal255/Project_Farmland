using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class Player_Audio_Controller : MonoBehaviour {
    private List<AudioClip> audio_clips;
    private bool development_mode = true;

	// Use this for initialization
	void Start () {
        audio_clips = new List<AudioClip>();
        AddClip("battle1", Resources.Load("Audio/berserk_forces") as AudioClip);
        PlayClip("battle1", 0.5f);
        if (development_mode)
            RunTests();
	}

    // if clip is not in audio_clips, then add it
    public void AddClip(string clip_name, AudioClip clip)
    {
        if (audio_clips.Contains(clip))
        {
            if (development_mode)
                Debug.Log(clip_name + " cannot be added, clip under track name " + clip.name);
        }
        else
        {
            clip.name = clip_name;
            audio_clips.Add(clip);
        }
    }

    // search through audio_clips by clip name, if found then remove clip
    public void RemoveClip(string clip_name)
    {
        bool removed_clip = false;
        foreach(AudioClip clip in audio_clips)
        {
            if (clip.name == clip_name)
            {
                audio_clips.Remove(clip);
                removed_clip = true;
            }
        }
        if (removed_clip)
            Debug.Log(clip_name + " removed from audio_clips list");
        else
            Debug.Log(clip_name + " cannot be removed, clip not in audio_clips list");
    }

    public void PlayClip(string clip_name, float volume)
    {
        foreach(AudioClip audio_clip in audio_clips)
        {
            if (audio_clip.name == clip_name)
                AudioSource.PlayClipAtPoint(audio_clip, gameObject.transform.position, volume);
        }
    }

    void RunTests()
    {
        TestAddClips();
        TestsPlayClip();
    }

    // test to determine same clips cannot be added to audio_clips
    void TestAddClips()
    {
        AddClip("battle1", Resources.Load("Audio/berserk_forces") as AudioClip);
        AddClip("battle2", Resources.Load("Audio/max_fury") as AudioClip);
        Assert.AreEqual(audio_clips.Count, 2, "TestAddClips: No match");
    }

    void TestsPlayClip()
    {
        PlayClip("battle1", 0.5f);
        StartCoroutine(WaitCoroutine(3));
    }

    IEnumerator WaitCoroutine(int seconds)
    {
        Debug.Log("about to yield return WaitForSeconds(" + seconds + ")");
        yield return new WaitForSeconds(seconds);
        Debug.Log("Just waited " + seconds + " seconds");
        PlayClip("battle1", 1.0f);
        yield break;
    }
}
