using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class IntroAudioController : MonoBehaviour {

	public AudioSource source;

	public void Play() {
		source.Play();
		StartCoroutine(finish());
	}

	IEnumerator finish() {
		while (source.isPlaying) yield return null;
		SceneManager.LoadScene("Game");
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
