using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {
    bool isTriggered = false;
    
    PlayerConroller playerController;

    
    public void OnCollisionEnter2D(Collision2D collision)
    {
        playerController = collision.gameObject.GetComponent<PlayerConroller>();
        
        playerController.shot();

        Destroy(gameObject);
    }
}
