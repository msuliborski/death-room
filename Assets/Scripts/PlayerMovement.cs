using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	Rigidbody2D _rigidbody;
    public Animator animator;
    public Joystick joystick;
	private float vel = 2.5f;
	private Vector2 dir = Vector2.zero;
	public GameObject start;

	void Start () {
		_rigidbody = gameObject.GetComponent<Rigidbody2D>();
		
		_rigidbody.velocity = new Vector2(0, 0);
	}
	
	void LateUpdate ()
	{

		stopAll();
		dir = Vector2.zero;

		if (start.active == false)

		{
			if (joystick.Vertical >= 0.2){
				stopAll();
				dir = new Vector2(dir.x, joystick.Vertical);
				animator.SetBool("Speed_up", true); 
			}
			if (joystick.Vertical <= -0.2){
				stopAll();
				dir = new Vector2(dir.x, joystick.Vertical);
				animator.SetBool("Speed_down", true);
			}
			if (joystick.Horizontal <= -0.2){
				stopAll();
				dir = new Vector2(joystick.Horizontal, dir.y);
				animator.SetBool("Speed_left", true);
			}
			if (joystick.Horizontal >= 0.2){
				stopAll();
				dir = new Vector2(joystick.Horizontal, dir.y);
				animator.SetBool("Speed_right", true);
			}
		}
		

        _rigidbody.velocity = dir.normalized * vel;

        

        

	}
	void stopAll(){
            animator.SetBool("Speed_up", false);
            animator.SetBool("Speed_down", false);
            animator.SetBool("Speed_left", false);
            animator.SetBool("Speed_right", false);
	}
}
