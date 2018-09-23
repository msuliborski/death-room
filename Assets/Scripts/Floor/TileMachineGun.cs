using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMachineGun : MonoBehaviour {
	public bool isTriggered = false;
    
    SpriteRenderer spriteRenderer;
    bool flag = false;
  
    void Start(){
        spriteRenderer = GetComponent<SpriteRenderer>();
     }

	void Update () {
       
    }
    IEnumerator Cooldown(float time)
    {
        flag = false;
        yield return new WaitForSeconds(time);
        flag = true;
    }
}
