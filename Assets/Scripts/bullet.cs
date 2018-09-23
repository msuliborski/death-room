using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {
    bool isTriggered = false;
    public GameObject explosion;
    PlayerConroller _playerController;

    // Use this for initialization

    public void OnTriggerEnter2D(Collider2D colliderPlayer)
    {
        Instantiate(explosion, this.transform.position, Quaternion.identity);

        //_playerController.shot();

        Destroy(this.gameObject);
    }
    public void OnCollisionEnter2D(Collision2D colliderPlayer)
    {
        Instantiate(explosion, this.transform.position, Quaternion.identity);

        //_playerController.shot();

        Destroy(this.gameObject);
    }
}
