using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour {

    public GameObject cannon;
	// Use this for initialization
	void Start () {
        StartCoroutine(Gun());
            
	}
	IEnumerator Gun()
    {
        yield return new WaitForSeconds(0.75f);
        cannon.SetActive(true);
    }
}
