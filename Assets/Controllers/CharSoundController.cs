using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CharSoundController : MonoBehaviour {

	AudioSource audioSource;
	public AudioSource audio_normal;
	public AudioSource audio_scare;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
	}

//	public void set_normal() {
//		audioSource.clip = audio_normal;
//		audioSource.volume = 0.166f;
//		audioSource.Play();
//	}
//
//	public void set_scare() {
//		audioSource.clip = scare;
//		audioSource.volume = 0.3f;
//		audioSource.Play();
//	}
//	
	void OnTriggerStay(Collider other) {
		if (other.gameObject.tag == "enemy") {
			audio_normal.Stop();
			audio_scare.UnPause();
		}
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "enemy") {
			audio_normal.Stop();
			if (!audio_scare.isPlaying) {
				audio_scare.Play();
			}
		}
	}

	void OnTriggerExit(Collider other) {
		if (other.gameObject.tag == "enemy") {
			audio_normal.Play();
			audio_scare.Pause();
		}
	}
}
