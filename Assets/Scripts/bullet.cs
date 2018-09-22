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
        Destroy(this.gameObject);
        _playerController.shot();
    }
}
