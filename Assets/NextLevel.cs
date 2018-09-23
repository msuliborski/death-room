using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour {

	bool enterNewLevel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter2D(Collider2D other) {
            
		Debug.Log("drzwi");
		GameObject.FindWithTag("Player").transform.position = new Vector2(1.658f, 2.204f);
		TilesPlacemant.spawnTiles();



	}
}
