using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileEmpty : MonoBehaviour {
	
	bool isTriggered = false;
 	SpriteRenderer spriteRenderer;
    public AudioClip clip;
    AudioSource source;

    void Start(){
        spriteRenderer = GetComponent<SpriteRenderer>();
        source = GetComponent<AudioSource>();
        source.clip = clip;
    }

	void Update () {

	}

	void OnTriggerEnter2D(Collider2D _colliderPlayer){
		if(!isTriggered){
			isTriggered = true;
        	//spriteRenderer.color = new Color(0.1f, 0.4f, 0.255f, 1f);
        	spriteRenderer.color = Color.green;
            source.PlayOneShot(source.clip);
	 	}
	}
}


