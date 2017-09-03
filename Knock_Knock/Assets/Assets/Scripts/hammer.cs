using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hammer : MonoBehaviour {
	public List<AudioClip> hammerSounds;
	AudioSource hammerSounding;
	// Use this for initialization
	void Start () {
		hammerSounding = this.gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision hammerCollision){
		if (hammerCollision.gameObject.CompareTag ("Metal")) {
			hammerSounding.clip = hammerSounds [0];
			hammerSounding.Play ();
		}

		if (hammerCollision.gameObject.CompareTag ("Wood")) {
			hammerSounding.clip = hammerSounds [1];
			hammerSounding.Play ();
		}
	}
}
