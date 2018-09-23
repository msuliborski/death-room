using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour {

	bool enterNewLevel;
    AudioSource source;
    public AudioClip clip;

	// Use this for initialization
	void Start () {
        source = GetComponent<AudioSource>();
        source.clip = clip;
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter2D(Collider2D other) {
            
		Debug.Log("drzwi");
		GameObject.FindWithTag("Player").transform.position = new Vector2(1.658f, 2.204f);
        source.PlayOneShot(source.clip);
		TilesPlacemant.spawnTiles();



	}
}
