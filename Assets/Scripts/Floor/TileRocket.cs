﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileRocket : MonoBehaviour {
	
	bool isTriggered = false;
 	SpriteRenderer spriteRenderer;
    public GameObject launcher;
    

    void Start(){
        spriteRenderer = GetComponent<SpriteRenderer>();
        
    }

	void Update () {
        
	}

	void OnTriggerEnter2D(Collider2D _colliderPlayer){
		if(!isTriggered){
			isTriggered = true;
            launcher.SetActive(true);
        	//spriteRenderer.color = new Color(0.1f, 0.4f, 0.255f, 1f);
        	spriteRenderer.color = Color.blue;
	 	}
	}
}