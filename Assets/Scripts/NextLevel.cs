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
        source.PlayOneShot(source.clip);
        TilesPlacemant.level++;
		GameObject.FindWithTag("Player").transform.position = new Vector2(1.5f, 2.2f);
		GameObject.FindWithTag("Player").GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
		TilesPlacemant.level++;
		TilesPlacemant.calculateLevelLength();
		TilesPlacemant.spawnTiles();
        RoomCounter.room++;
        
    }
}
