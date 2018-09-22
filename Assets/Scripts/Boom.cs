using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boom : MonoBehaviour {

    float explosionTimer = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        explosionTimer += Time.deltaTime;
        if (explosionTimer >= 0.6) Destroy(gameObject);
	}
}
