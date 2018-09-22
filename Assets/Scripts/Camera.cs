using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {


    private GameObject _player;

	// Use this for initialization
	void Start () {
        _player = GameObject.FindGameObjectWithTag("Player");
        //transform.position = new Vector3(_player.transform.position.x, GameObject.position.y, GameObject.position.z);
	}
	
	// Update is called once per frame
	void LateUpdate () {
		if (_player != null){
			Vector3 dest = new Vector3(_player.transform.position.x, position.y - 2, position.z);
			if (transform.position != dest){
				float step = 2f * Time.deltaTime;
				transform.position = Vector3.MoveTowards(transform.position, dest, step);
			}
        }
	}
}
