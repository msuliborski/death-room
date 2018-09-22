using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	Rigidbody2D _rigidbody;
    public Animator animator;
	float vel = 4f;

	void Start () {
		_rigidbody = gameObject.GetComponent<Rigidbody2D>();
		_rigidbody.velocity = new Vector2(0, 0);
	}
	
	
	void LateUpdate () {

        if (Input.GetKeyDown(KeyCode.W)){
			stopAll();
            animator.SetBool("Speed_up", true); 
        }
        else if (Input.GetKeyDown(KeyCode.S)){
			stopAll();
            animator.SetBool("Speed_down", true);
        }
        else if (Input.GetKeyDown(KeyCode.A)){
			stopAll();
            animator.SetBool("Speed_left", true);
        }
        else if (Input.GetKeyDown(KeyCode.D)){
			stopAll();
            animator.SetBool("Speed_right", true);
        }

		
		if (Input.GetKeyUp(KeyCode.W)) animator.SetBool("Speed_up", false); 
		if (Input.GetKeyUp(KeyCode.S)) animator.SetBool("Speed_down", false); 
		if (Input.GetKeyUp(KeyCode.A)) animator.SetBool("Speed_left", false); 
		if (Input.GetKeyUp(KeyCode.D)) animator.SetBool("Speed_right", false); 



        if (Input.GetKey(KeyCode.W)) _rigidbody.velocity = new Vector3(_rigidbody.velocity.x, vel, 0);
        if (Input.GetKeyUp(KeyCode.W)) _rigidbody.velocity = new Vector3(_rigidbody.velocity.x, 0, 0);
        if (Input.GetKey(KeyCode.S)) _rigidbody.velocity = new Vector3(_rigidbody.velocity.x, -vel, 0);
        if (Input.GetKeyUp(KeyCode.S)) _rigidbody.velocity = new Vector3(_rigidbody.velocity.x, 0, 0);
        if (Input.GetKey(KeyCode.A)) _rigidbody.velocity = new Vector3(-vel, _rigidbody.velocity.y, 0);
        if (Input.GetKeyUp(KeyCode.A)) _rigidbody.velocity = new Vector3(0, _rigidbody.velocity.y, 0);
        if (Input.GetKey(KeyCode.D)) _rigidbody.velocity = new Vector3(vel, _rigidbody.velocity.y, 0);
        if (Input.GetKeyUp(KeyCode.D)) _rigidbody.velocity = new Vector3(0, _rigidbody.velocity.y, 0);
	}
	void stopAll(){
            animator.SetBool("Speed_up", false);
    
            animator.SetBool("Speed_down", false);
    
            animator.SetBool("Speed_left", false);
    
            animator.SetBool("Speed_right", false);
	}
}
