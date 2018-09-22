using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour {

    public float speed = 5f;
    public float rotatingSpeed = 200f;
    public GameObject _player;
    Rigidbody2D rb;
	
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}

    private void FixedUpdate()
    {
        Vector2 point2target = (Vector2)transform.position - (Vector2)_player.transform.position;
        point2target.Normalize();
        float value = Vector3.Cross(point2target, -transform.right).z;
        if (value > 0)
        {
            rb.angularVelocity = rotatingSpeed;
        }
        else if (value < 0)
        {
            rb.angularVelocity = -rotatingSpeed;
        }
        else
            rb.angularVelocity = 0;

        rb.velocity = -transform.right * speed;
    }
    
}
