using UnityEngine;
using System.Collections;

public class EnemyAudioController : MonoBehaviour {

	public SoundPool pool;
	public SoundPoolObj soundPoolObj;

	public void setAudioActive(bool value) {
		if (value) {
			if (soundPoolObj == null) {
				soundPoolObj = pool.alloc(transform);
			}
		} else {
			if (soundPoolObj != null) {
				soundPoolObj.detatch();
				soundPoolObj = null;
			}
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
