using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	Rigidbody2D _rigidbody;
    public Animator animator;
    public Joystick joystick;
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

        if (joystick.Vertical > 0){
			stopAll();
            animator.SetBool("Speed_up", true); 
        }
        else if (joystick.Vertical < 0){
            stopAll();
            animator.SetBool("Speed_down", true);
        }
        else if (joystick.Horizontal < 0){
            stopAll();
            animator.SetBool("Speed_left", true);
        }
        else if (joystick.Horizontal > 0){
            stopAll();
            animator.SetBool("Speed_right", true);
        }


        if (joystick.Vertical == 0)
        {
	        animator.SetBool("Speed_up", false);
	        animator.SetBool("Speed_down", false); 
        }

        if (joystick.Horizontal == 0)
        {
	        animator.SetBool("Speed_left", false);
	        animator.SetBool("Speed_right", false);
        } 

        if (joystick.Vertical > 0) _rigidbody.velocity = new Vector3(_rigidbody.velocity.x, vel, 0);
        if (joystick.Vertical == 0) _rigidbody.velocity = new Vector3(_rigidbody.velocity.x, 0, 0);
        if (joystick.Vertical < 0) _rigidbody.velocity = new Vector3(_rigidbody.velocity.x, -vel, 0);
        
        if (joystick.Horizontal < 0) _rigidbody.velocity = new Vector3(-vel, _rigidbody.velocity.y, 0);
        if (joystick.Horizontal == 0) _rigidbody.velocity = new Vector3(0, _rigidbody.velocity.y, 0);
        if (joystick.Horizontal > 0) _rigidbody.velocity = new Vector3(vel, _rigidbody.velocity.y, 0);
        
	}
	void stopAll(){
            animator.SetBool("Speed_up", false);
            animator.SetBool("Speed_down", false);
            animator.SetBool("Speed_left", false);
            animator.SetBool("Speed_right", false);
	}
}
