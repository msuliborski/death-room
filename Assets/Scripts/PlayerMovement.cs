using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	Rigidbody2D _rigidbody;
	public Animator _animator;

	float maxForce = 150f;

	void Start () {
		_rigidbody = gameObject.GetComponent<Rigidbody2D>();
        _animator = gameObject.GetComponent<Animator>();
		_rigidbody.velocity = new Vector2(0, 0);
	}
	
	
	void LateUpdate () {

		if (Input.GetKeyDown(KeyCode.W)) {
			_rigidbody.AddForce(new Vector2(0, maxForce));
			
			}
		if (Input.GetKeyUp(KeyCode.W)) _rigidbody.AddForce(new Vector2(0, -maxForce));

		if (Input.GetKeyDown(KeyCode.S)) _rigidbody.AddForce(new Vector2(0, -maxForce));
		if (Input.GetKeyUp(KeyCode.S)) _rigidbody.AddForce(new Vector2(0, maxForce));

		if (Input.GetKeyDown(KeyCode.A)) _rigidbody.AddForce(new Vector2(-maxForce, 0));
		if (Input.GetKeyUp(KeyCode.A)) _rigidbody.AddForce(new Vector2(maxForce, 0));

		if (Input.GetKeyDown(KeyCode.D)) _rigidbody.AddForce(new Vector2(maxForce, 0));
		if (Input.GetKeyUp(KeyCode.D)) _rigidbody.AddForce(new Vector2(-maxForce, 0));
	}
}
