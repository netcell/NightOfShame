using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CharSoundController : MonoBehaviour {

	AudioSource audioSource;
	public AudioSource audio_normal;
	public AudioSource audio_scare;
	AttackedController attackedController;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
		attackedController = GetComponent<AttackedController>();
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "enemy") {
			if (!attackedController.beingAttacked) {
				attackedController.Play();
			}
		}
	}
}
