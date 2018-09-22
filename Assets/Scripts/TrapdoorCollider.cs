using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapdoorCollider : MonoBehaviour {

    PlayerConroller playerController;
    AudioSource source;
    public AudioClip clip;

    private void Start()
    {
        source = GetComponent<AudioSource>();
        source.clip = clip;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        playerController = collision.gameObject.GetComponent<PlayerConroller>();
        if(collision.gameObject.tag == "Player")
        {
            playerController.Fall();
            source.PlayOneShot(source.clip);
        }
    }

    
}
