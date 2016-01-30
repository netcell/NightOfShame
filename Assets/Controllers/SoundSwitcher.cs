using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System;

public abstract class SoundSwitcher : MonoBehaviour {

	protected AudioSource source;
	Type thisType;
	List<PropertyInfo> properties;
	string current;
	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource>();
		thisType = this.GetType();
	}

	public void loadClip(string clipName) {
		if (current != clipName) {
			AudioClip clip = thisType.GetProperty(clipName).GetValue(this, new object[]{}) as AudioClip;
			if (clip != null) {
				source.clip = clip;
				source.Play();	
				current = clipName;
			}
		}
	}

	public float volume {
		get {
			return source.volume;
		}
		set {
			source.volume = value;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
