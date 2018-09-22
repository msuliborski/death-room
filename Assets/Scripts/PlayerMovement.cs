using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	Rigidbody2D _rigidbody;
 	CharacterController characterController;




	float maxForce = 10f;

	public Vector2 moveDirection;
	public Vector2 b;
	public float maxDashTime = 1.0f;
	public float dashSpeed = 1.0f;
	public float dashStoppingSpeed = 0.2f;
	public float currentDashTime = 10f;
	bool d;

	void Start () {
		_rigidbody = gameObject.GetComponent<Rigidbody2D>();
        characterController = GetComponent<CharacterController>();
		_rigidbody.velocity = new Vector2(0, 0);
	}
	
	void LateUpdate () {

		Vector2 velocity = new Vector2(0, 0);
		if (Input.GetKey(KeyCode.W)) velocity += new Vector2(0, maxForce);
		if (Input.GetKey(KeyCode.S)) velocity += new Vector2(0, -maxForce);
		if (Input.GetKey(KeyCode.A)) velocity += new Vector2(-maxForce, 0);
		if (Input.GetKey(KeyCode.D)) velocity += new Vector2(maxForce, 0);

		_rigidbody.velocity = velocity;
	


	if (Input.GetKeyDown(KeyCode.Space)){
		currentDashTime = 0.0f;
		_rigidbody.velocity = new Vector2(_rigidbody.velocity.x*10, _rigidbody.velocity.y*10);
		d = true;
	}
	
	if (currentDashTime < maxDashTime){
		currentDashTime += dashStoppingSpeed;
	}
	else if (d){
		d = false;
		_rigidbody.velocity = new Vector2(_rigidbody.velocity.x/10, _rigidbody.velocity.y/10);
	}
	

	}
	
}
