using UnityEngine;
using System.Collections;

public class SoundPoolObj : MonoBehaviour {

	public GameObject objectPool;
	public AudioSource source;

	void Start() {
	}

	public void attach(Transform parent) {
		transform.parent = parent;
		transform.localPosition = new Vector3(0, 0, 0);
		gameObject.SetActive(true);
	}

	public void detatch() {
		transform.parent = objectPool.transform;
		gameObject.SetActive(false);
	}

}
