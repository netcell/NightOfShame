using UnityEngine;
using System.Collections;

public class Radar : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "enemy") {
			other.GetComponent<EnemyAudioController>().setAudioActive(true);
		}
	}

	void OnTriggerStay(Collider other) {
		if (other.gameObject.tag == "enemy") {
			EnemyAudioController controller = other.GetComponent<EnemyAudioController>();
			if (controller.soundPoolObj == null) {
				controller.setAudioActive(true);	
			}
		}
	}

	void OnTriggerExit(Collider other) {
		if (other.gameObject.tag == "enemy") {
			other.GetComponent<EnemyAudioController>().setAudioActive(false);
		}
	}
}
