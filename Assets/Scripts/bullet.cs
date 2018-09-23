using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {
    bool isTriggered = false;
    public GameObject explosion;
    PlayerConroller playerController;

    
    public void OnCollisionEnter2D(Collision2D collision)
    {
        playerController = collision.gameObject.GetComponent<PlayerConroller>();
        Instantiate(explosion, this.transform.position, Quaternion.identity);

        playerController.shot();

        Destroy(gameObject);
    }
}
