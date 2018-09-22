using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapdoorCollider : MonoBehaviour {

    PlayerConroller playerController;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 5)
        {
            playerController.Fall();
        }
    }

    
}
