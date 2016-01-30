using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AttackedController : MonoBehaviour {

	public AudioClip caughtClip;
	public AudioClip cryClip;

	public AudioSource source;
	public List<AudioClip> attackedClips;
	public List<GameObject> tobePaused;
	float[] panStereoOptions = new float[]{0.8f, -0.8f};
	public bool beingAttacked = false;

	public void Play() {
		if (beingAttacked) return;
		beingAttacked = true;
		tobePaused.ForEach(sourceTBP => {
			sourceTBP.SetActive(false);
		});

		StartCoroutine(cry());
	}

	public void Reset() {
		StartCoroutine(reset());
	}

	IEnumerator cry() {
		source.clip = caughtClip;
		source.loop = false;
		source.panStereo = 0;
		source.Play();
		while (source.isPlaying) {
			yield return null;
		}

		source.clip = attackedClips[Random.Range(0, attackedClips.Count)];
		source.panStereo = panStereoOptions[Random.Range(0, panStereoOptions.Length)];
		source.Play();
		while (source.isPlaying) {
			yield return null;
		}

		source.clip = cryClip;
		source.loop = true;
		source.panStereo = 0;
		source.Play();
	}

	IEnumerator reset() {
		tobePaused.ForEach(source => {
			source.SetActive(true);
		});
		source.Stop();
		yield return new WaitForSeconds(4);
		beingAttacked = false;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
