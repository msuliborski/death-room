using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blood : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.transform.Rotate(Vector3.forward * Random.Range(0, 360));
	}
	
	
}
