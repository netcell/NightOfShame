using UnityEngine;
using System.Collections;

public class Radar : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "enemy") {
			Debug.Log("fdsafdas");
			other.GetComponent<EnemyAudioController>().obj.SetActive(true);
		}
	}

	void OnTriggerExit(Collider other) {
		if (other.gameObject.tag == "enemy") {
			other.GetComponent<EnemyAudioController>().obj.SetActive(false);
		}
	}
}
