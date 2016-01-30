using UnityEngine;
using System.Collections;

public class SoundPool : MonoBehaviour {

	public SoundPoolObj alloc(Transform parent) {
		var children = GetComponentInChildren<SoundPoolObj>(true);
		if (children != null) {
			children.attach(parent);
		}
		return children;
	}
}
