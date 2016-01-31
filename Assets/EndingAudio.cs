using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class EndingAudio : MonoBehaviour {

	public AudioClip ending1;
	public AudioClip ending2;
	public AudioClip ending3;
	public AudioSource source;

	public static AudioClip ending;

	// Use this for initialization
	void Start () {
		if (source != null && ending != null) {
			source.clip = ending;
			source.Play();
			StartCoroutine(run());
		}
	}

	public void end1(){
		ending = ending1;
		SceneManager.LoadScene("Ending");
	}

	public void end2(){
		ending = ending2;
		SceneManager.LoadScene("Ending");
	}

	public void end3(){
		ending = ending3;
		SceneManager.LoadScene("Ending");
	}

	IEnumerator run() {
		while (source.isPlaying) yield return null;
		SceneManager.LoadScene("Menu");
	}
}
