using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {
    bool isTriggered = false;
    public GameObject explosion;
    PlayerConroller playerController;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D _colliderPlayer)
    {
        if (!isTriggered)
        {
            isTriggered = true;
            Instantiate(explosion, this.transform.position, Quaternion.identity);
            Destroy(this.gameObject);
            playerController.shot();
        }
    }
}
