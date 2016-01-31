using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class OnEnterDisable : MonoBehaviour {

	public List<GameObject> onEnterDisable;
	public List<GameObject> onEnterEnable;
	public List<GameObject> onExitEnable;
	public List<GameObject> onExitDisable;

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Player") {
			onEnterDisable.ForEach(sourceTBP => {
				sourceTBP.SetActive(false);
			});
			onEnterEnable.ForEach(sourceTBP => {
				sourceTBP.SetActive(true);
			});
		}
	}

	void OnTriggerExit(Collider other) {
		if (other.gameObject.tag == "Player") {
			onExitEnable.ForEach(sourceTBP => {
				sourceTBP.SetActive(true);
			});
			onExitDisable.ForEach(sourceTBP => {
				sourceTBP.SetActive(false);
			});
		}
	}
}
