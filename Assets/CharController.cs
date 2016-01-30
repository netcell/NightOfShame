using UnityEngine;
using System.Collections;

public class CharController : MonoBehaviour {

	float x;
	float y;
	private Gyroscope gyro;
	float gyroSensitivity = 50f;

	public void TurnLeft() {
		Quaternion rotation = transform.rotation;
		Vector3 angle = rotation.eulerAngles;
		angle.y -= 10;
		rotation.eulerAngles = angle;
		transform.rotation = rotation;
	}

	public void TurnRight() {
		Quaternion rotation = transform.rotation;
		Vector3 angle = rotation.eulerAngles;
		angle.y += 10;
		rotation.eulerAngles = angle;
		transform.rotation = rotation;
	}

	// Use this for initialization
	void Start () {
		if (SystemInfo.supportsGyroscope) {
			gyro = Input.gyro;
			gyro.enabled = true;
		}
	}

	void OnGUI()
	{
		GUILayout.Label("Gyroscope rotationRate : " + gyro.rotationRate);
		GUILayout.Label("Gyroscope rotationRate : " + gyro.rotationRate);
	}
	
	// Update is called once per frame
	void Update () {
		var x = gyro.rotationRate.x;
		var y = gyro.rotationRate.y;
		var z = gyro.rotationRate.z;
		transform.RotateAround(transform.position, new Vector3(0,1,0), -y * Time.deltaTime * gyroSensitivity);
	}
}
