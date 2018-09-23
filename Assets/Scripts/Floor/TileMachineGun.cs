using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMachineGun : MonoBehaviour {
	public bool isTriggered = false;
    static GameObject player;
    
    SpriteRenderer spriteRenderer;
    bool flag = false;
  
    void Start(){
        spriteRenderer = GetComponent<SpriteRenderer>();
    player = GameObject.FindGameObjectWithTag("Player");
     }

	void Update () {
		if (Mathf.Abs((transform.position - player.transform.position).magnitude) < 50)
            spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, TileEmpty.getAlphaRatio(transform.position));
    }
    
    IEnumerator Cooldown(float time)
    {
        flag = false;
        yield return new WaitForSeconds(time);
        flag = true;
    }
}
