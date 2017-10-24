using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume_Slider : MonoBehaviour {
    //[SerializeField] private AudioListener player_listener;
    private Scrollbar volume_slider;
    private Text volume_label;
    private float volume;

	// Use this for initialization
	void Start () {
        volume_slider = gameObject.GetComponent<Scrollbar>();
        volume_label = gameObject.GetComponentInChildren<Text>();
        volume = volume_slider.value * 100;
        volume_label.text = "Volume " + (int)volume + "%";
        Debug.Log(volume_label.text);

        //Adds a listener to the main slider and invokes a method when the value changes.
        volume_slider.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
    }

    // Invoked when the value of the slider changes.
    public void ValueChangeCheck()
    {
        AudioListener.volume = volume_slider.value;
        volume = volume_slider.value * 100;
        volume_label.text = "Volume " + (int)volume + "%";
        Debug.Log(volume_label.text);
        Debug.Log(volume_slider.value);
    }
}
