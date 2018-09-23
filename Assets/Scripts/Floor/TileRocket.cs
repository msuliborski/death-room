using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileRocket : MonoBehaviour {
	
	bool isTriggered = false;
 	SpriteRenderer spriteRenderer;
    public GameObject launcher;
    GameObject player;
    

    void Start(){
        spriteRenderer = GetComponent<SpriteRenderer>();
        player = GameObject.FindGameObjectWithTag("Player");
        
    }

	void Update () {
		if (Mathf.Abs((transform.position - player.transform.position).magnitude) < 50)
        	spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, TileEmpty.getAlphaRatio(transform.position));
	}

	void OnTriggerEnter2D(Collider2D _colliderPlayer){
		if(!isTriggered){
			isTriggered = true;
            launcher.SetActive(true);
        	//spriteRenderer.color = new Color(0.1f, 0.4f, 0.255f, 1f);
        	spriteRenderer.color = Color.red;
	 	}
	}
}