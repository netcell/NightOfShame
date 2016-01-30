using UnityEngine;
using System.Collections;

public class EnemyPatrol : MonoBehaviour {

	public float speed;
	Vector3 original;

	// Use this for initialization
	void Start () {
		original = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += transform.forward * Random.Range(-1f, 1f) * Time.deltaTime * speed;
	}
}
