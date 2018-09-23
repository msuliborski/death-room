using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour {

    PlayerConroller playerController;
    public float speed = 3f;
    public float rotatingSpeed = 200f;
    GameObject _player;
    public GameObject boom;
    Rigidbody2D rb;
	
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        _player = GameObject.FindGameObjectWithTag("Player");
        StartCoroutine(destroy());
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        playerController = collision.gameObject.GetComponent<PlayerConroller>();
        if (collision.gameObject.tag == "Player")
        {
            Instantiate(boom, transform.position, Quaternion.identity);
            playerController.Kaboom();
            Destroy(gameObject);
        }
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
    
    IEnumerator destroy()
    {
        yield return new WaitForSeconds(3f);
        Destroy(gameObject);
    }
}
