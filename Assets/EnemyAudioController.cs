using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyAudioController : MonoBehaviour {

	public SoundPool pool;
	public SoundPoolObj soundPoolObj;
	public AudioClip[] tauntClips;
	public AudioClip[] laughClips;
	IEnumerator tauntCoroutine;
	IEnumerator detatchCoroutine;

	public void setAudioActive(bool value) {
		if (!gameObject.activeInHierarchy) return;
		if (value) {
			if (soundPoolObj == null) {
				soundPoolObj = pool.alloc(transform);
				if (soundPoolObj != null)
					soundPoolObj.source.UnPause();
				tauntCoroutine = taunt();
				if (detatchCoroutine != null)
					StopCoroutine(detatchCoroutine);
				StartCoroutine(tauntCoroutine);
			}
		} else {
			if (soundPoolObj != null) {
				if (!soundPoolObj.source.isPlaying) {
					soundPoolObj.detatch();
					soundPoolObj = null;
				} else {
					detatchCoroutine = detatch();
					StartCoroutine(detatchCoroutine);
				}
				if (tauntCoroutine != null)
					StopCoroutine(tauntCoroutine);
			}
		}
	}

	IEnumerator detatch() {
		
		if (soundPoolObj != null) {
			var source = soundPoolObj.source;
			while (source.isPlaying) {
				yield return null;
			}
		}
		if (soundPoolObj != null) {
			soundPoolObj.detatch();
			soundPoolObj = null;
		}
	}

	IEnumerator taunt() {
		while (soundPoolObj != null) {
			var source = soundPoolObj.source;
			while (source.isPlaying) {
				yield return null;
			}
			int index = Random.Range(0, tauntClips.Length);
			Debug.Log(index + " " + tauntClips.Length);
			source.clip = tauntClips[index];
//			yield return new WaitForSeconds(2);
			source.Play();
		}
	}

	// Use this for initialization
	void Start () {
//		pool = GetComponentInParent<SoundPool>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
