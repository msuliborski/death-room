using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	Rigidbody2D _rigidbody;
    public Animator animator;
	float vel = 3.3f;

	void Start () {
        Debug.Log("wdwd");
		// StartCoroutine(Example());
		_rigidbody = gameObject.GetComponent<Rigidbody2D>();
		//_rigidbody.isKinematic = true;
		_rigidbody.velocity = new Vector2(0, 0);
		//transform.position = transform.position - new Vector3(2, 0, 0);
		// Vector2 d = transform.position;
		//Vector2 dd = transform.position + new Vector3(2, 0);
		// transform.position = Vector2.MoveTowards(d, new Vector2(1.81, 2.07), 50);
	}

	// IEnumerator Example()
    // {
    //     print(Time.time);
    //     yield return new WaitForSeconds(1);
    //     print(Time.time);
    // }
	
	void LateUpdate () {

        if ((Input.GetKeyDown(KeyCode.W))|| (Input.GetKeyDown(KeyCode.UpArrow))){
			stopAll();
            animator.SetBool("Speed_up", true); 
        }
        else if ((Input.GetKeyDown(KeyCode.S))|| (Input.GetKeyDown(KeyCode.DownArrow))){
            stopAll();
            animator.SetBool("Speed_down", true);
        }
        else if ((Input.GetKeyDown(KeyCode.A))|| (Input.GetKeyDown(KeyCode.LeftArrow))){
            stopAll();
            animator.SetBool("Speed_left", true);
        }
        else if ((Input.GetKeyDown(KeyCode.D))|| (Input.GetKeyDown(KeyCode.RightArrow))){
            stopAll();
            animator.SetBool("Speed_right", true);
        }

		
		if ((Input.GetKeyUp(KeyCode.W))|| (Input.GetKeyUp(KeyCode.UpArrow))) animator.SetBool("Speed_up", false); 
		if ((Input.GetKeyUp(KeyCode.S))|| (Input.GetKeyUp(KeyCode.DownArrow))) animator.SetBool("Speed_down", false); 
		if ((Input.GetKeyUp(KeyCode.A))|| (Input.GetKeyUp(KeyCode.LeftArrow))) animator.SetBool("Speed_left", false); 
		if ((Input.GetKeyUp(KeyCode.D))|| (Input.GetKeyUp(KeyCode.RightArrow))) animator.SetBool("Speed_right", false); 



        if ((Input.GetKey(KeyCode.W))|| (Input.GetKey(KeyCode.UpArrow))) _rigidbody.velocity = new Vector3(_rigidbody.velocity.x, vel, 0);
        if ((Input.GetKeyUp(KeyCode.W))|| (Input.GetKeyUp(KeyCode.UpArrow))) _rigidbody.velocity = new Vector3(_rigidbody.velocity.x, 0, 0);
        if ((Input.GetKey(KeyCode.S))|| (Input.GetKey(KeyCode.DownArrow))) _rigidbody.velocity = new Vector3(_rigidbody.velocity.x, -vel, 0);
        if ((Input.GetKeyUp(KeyCode.S))|| (Input.GetKeyUp(KeyCode.DownArrow))) _rigidbody.velocity = new Vector3(_rigidbody.velocity.x, 0, 0);
        if ((Input.GetKey(KeyCode.A))|| (Input.GetKey(KeyCode.LeftArrow))) _rigidbody.velocity = new Vector3(-vel, _rigidbody.velocity.y, 0);
        if ((Input.GetKeyUp(KeyCode.A))|| (Input.GetKeyUp(KeyCode.LeftArrow))) _rigidbody.velocity = new Vector3(0, _rigidbody.velocity.y, 0);
        if ((Input.GetKey(KeyCode.D))|| (Input.GetKey(KeyCode.RightArrow))) _rigidbody.velocity = new Vector3(vel, _rigidbody.velocity.y, 0);
        if ((Input.GetKeyUp(KeyCode.D))|| (Input.GetKeyUp(KeyCode.RightArrow))) _rigidbody.velocity = new Vector3(0, _rigidbody.velocity.y, 0);
	}
	void stopAll(){
            animator.SetBool("Speed_up", false);
            animator.SetBool("Speed_down", false);
            animator.SetBool("Speed_left", false);
            animator.SetBool("Speed_right", false);
	}
}
