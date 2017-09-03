using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour {

    public List<AudioClip> WallKnocks;
    AudioSource WallKnock;

    // Use this for initialization
    void Start() {
   
        WallKnock = this.gameObject.GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update() {

    }

    void OnTriggerEnter(Collider other)
    {

        if(other.transform.parent.parent.gameObject)
        {
            //Debug.Log(other.transform.parent.parent.gameObject.name);
            if (other.transform.parent.parent.gameObject.tag=="GameController")
            {
            Debug.Log("enter");
            WallKnock.clip = WallKnocks[Random.Range(0, WallKnocks.Count-1)];
            WallKnock.Play();
            }
        }

    }
}
