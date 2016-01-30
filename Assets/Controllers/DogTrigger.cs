using UnityEngine;
using System.Collections;

public class DogTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

//	void OnTriggerStay(Collider other) {
//		CharSoundController sound = other.GetComponentInChildren<CharSoundController>();
//		if (sound != null) {
//			if (!sound.is_scared) {
//				sound.is_scared = true;
//				sound.setValue();
//			}
//		}
//	}
//
//	void OnTriggerEnter(Collider other) {
//		CharSoundController sound = other.GetComponentInChildren<CharSoundController>();
//		if (sound != null) {
//			sound.is_scared = true;
//			sound.setValue();
//		}
//	}
//
//	void OnTriggerExit(Collider other) {
//		CharSoundController sound = other.GetComponentInChildren<CharSoundController>();
//		if (sound != null) {
//			sound.is_scared = false;
//			sound.setValue();
//		}
//	}
}
