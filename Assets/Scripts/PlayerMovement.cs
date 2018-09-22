using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	Rigidbody2D _rigidbody;
    public Animator animator;
	float maxForce = 900f;

	void Start () {
		_rigidbody = gameObject.GetComponent<Rigidbody2D>();
		_rigidbody.velocity = new Vector2(0, 0);
	}
	
	
	void LateUpdate () {

        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetBool("Speed_up", true);
            _rigidbody.AddForce(new Vector2(0, maxForce));
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool("Speed_up", false);
            _rigidbody.AddForce(new Vector2(0, -maxForce));
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetBool("Speed_down", true);
            _rigidbody.AddForce(new Vector2(0, -maxForce));
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            animator.SetBool("Speed_down", false);
            _rigidbody.AddForce(new Vector2(0, maxForce));
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetBool("Speed_left", true);
            _rigidbody.AddForce(new Vector2(-maxForce, 0));
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            animator.SetBool("Speed_left", false);
            _rigidbody.AddForce(new Vector2(maxForce, 0));
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetBool("Speed_right", true);
            _rigidbody.AddForce(new Vector2(maxForce, 0));
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("Speed_right", false);
            _rigidbody.AddForce(new Vector2(-maxForce, 0));
        }
	}
}
