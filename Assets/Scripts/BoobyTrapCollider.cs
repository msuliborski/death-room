using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoobyTrapCollider : MonoBehaviour {

    PlayerConroller playerController;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        playerController = collision.gameObject.GetComponent<PlayerConroller>();
        if(collision.gameObject.tag == "Player")
        {
            playerController.Kaboom();
        }
    }
}
