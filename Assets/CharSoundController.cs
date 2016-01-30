using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CharSoundController : MonoBehaviour {

	AudioSource audioSource;
	public AudioClip normal;
	public AudioClip scare;
	public bool is_scared = false;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
	}

	public void setValue() {
		if (is_scared) {
			this.set_scare();
		} else {
			this.set_normal();
		}
	}

	public void set_normal() {
		audioSource.clip = normal;
		audioSource.volume = 0.166f;
		audioSource.Play();
	}



	public void set_scare() {
		audioSource.clip = scare;
		audioSource.volume = 0.3f;
		audioSource.Play();
	}
	
	// Update is called once per frame
	void Update () {
	}
}
