using UnityEngine;
using System.Collections;

public class charmove : MonoBehaviour {

	public float speed;
	CharacterController controller;
	public AudioSource audioSource;

	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
//		move();
	}

	public void move() {
		transform.position += transform.forward * speed;
		audioSource.Play();
//		Vector3 move = Quaternion.Euler(0, transform.eulerAngles.y, 0) * new Vector3(0, 0, speed);
//		transform.Translate(move);
	}
}
