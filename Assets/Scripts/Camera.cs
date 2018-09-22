using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {


    private GameObject _player;
	Vector3 offset;

	// Use this for initialization
	void Start () {
        _player = GameObject.FindGameObjectWithTag("Player");
        offset = new Vector3(gameObject.transform.position.x - _player.transform.position.x, 0, 0);
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = new Vector3(_player.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z) + offset;
	}
}
