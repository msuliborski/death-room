using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startScript : MonoBehaviour {
	GameObject _player;

	bool initialized = false;
	// Use this for initialization

	
	public void Staart () 
	{
		_player = GameObject.FindGameObjectWithTag("Player");
		if (!initialized)
		{
			initialized = true;
			_player.GetComponent<Rigidbody2D>().isKinematic = false;
			_player.GetComponent<SpriteRenderer>().enabled = true;
			_player.transform.position = new Vector2(1.63f, 2.2f);
			gameObject.SetActive(false);
		}
	}
		
}
