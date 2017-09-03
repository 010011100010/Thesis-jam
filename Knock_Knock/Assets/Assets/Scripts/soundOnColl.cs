using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundOnColl : MonoBehaviour {
    public List<AudioClip> Sounds;
    AudioSource Sounding;
    // Use this for initialization
    void Start () {
        Sounding = this.gameObject.GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter()
    {
        Sounding.clip = Sounds[Random.Range(0, Sounds.Count-1)];
        Sounding.Play();
    }
}
