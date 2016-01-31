using UnityEngine;
using System.Collections;

public class charmove : MonoBehaviour {

	public float speed;
	public float radius;
	CharacterController controller;
	public AudioSource audioSourceLeft;
	public AudioSource audioSourceRight;

	bool movable = true;

	int speedCount    = 0;
	float timeStamp     = 0;
	float timeThreshold = 0.5f;
	int speedCountThreshold = 3;

	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
//		move();
	}

	bool moved = false;
	bool movedLeft = false;

	public void moveLeft() {
		if (movable && (!moved || !movedLeft)) {
			audioSourceLeft.Play();
			move();
			movedLeft = true;
		}
	}

	public void moveRight() {
		if (movable && (!moved || movedLeft)) {
			audioSourceRight.Play();
			move();
			movedLeft = false;
		}
	}

	public AudioSource source;

	public void move() {
		moved = true;
		if (Time.time - timeStamp < timeThreshold) {
			speedCount++;
		} else speedCount = 0;
		if (speedCount > speedCountThreshold) {
			movable = false;
		}
		if (!movable) {
			source.Play();
			StartCoroutine(deStun());
			return;
		}
		transform.position += transform.forward * speed;
		if (Vector3.Magnitude(transform.localPosition) > radius) {
			transform.localPosition = Vector3.ClampMagnitude(transform.localPosition, radius);
		}
		timeStamp = Time.time;
	}

	IEnumerator deStun() {
		while (source.isPlaying) {
			yield return null;
		}
		movable = true;
	}
}
