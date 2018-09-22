using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {
    bool isTriggered = false;
    public GameObject explosion;
    PlayerConroller _playerController;

    // Use this for initialization

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _playerController = collision.gameObject.GetComponent<PlayerConroller>();
        if(collision.gameObject.tag == "Player")
        {
            _playerController.shot();
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
