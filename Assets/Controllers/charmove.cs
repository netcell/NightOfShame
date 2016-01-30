using UnityEngine;
using System.Collections;

public class charmove : MonoBehaviour {

	public float speed;
	public float radius;
	CharacterController controller;
	public AudioSource audioSourceLeft;
	public AudioSource audioSourceRight;

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
		if (!moved || !movedLeft) {
			audioSourceLeft.Play();
			move();
			movedLeft = true;
		}
	}

	public void moveRight() {
		if (!moved || movedLeft) {
			audioSourceRight.Play();
			move();
			movedLeft = false;
		}
	}

	public void move() {
		moved = true;
		transform.position += transform.forward * speed;
		if (Vector3.Magnitude(transform.localPosition) > radius) {
			transform.localPosition = Vector3.ClampMagnitude(transform.localPosition, radius);
		}
	}
}
