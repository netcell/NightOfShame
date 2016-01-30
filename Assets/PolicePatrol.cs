using UnityEngine;
using System.Collections;

public class PolicePatrol : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var rotation = transform.rotation;
		var angle = rotation.eulerAngles;
		angle.y += Time.deltaTime * speed;
		rotation.eulerAngles = angle;
		transform.rotation = rotation;
	}
}
