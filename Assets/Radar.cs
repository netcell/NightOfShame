using UnityEngine;
using System.Collections;

public class Radar : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "enemy") {
			other.GetComponent<EnemyAudioController>().setAudioActive(true);
		}
	}

	void OnTriggerExit(Collider other) {
		if (other.gameObject.tag == "enemy") {
			other.GetComponent<EnemyAudioController>().setAudioActive(false);
		}
	}
}
