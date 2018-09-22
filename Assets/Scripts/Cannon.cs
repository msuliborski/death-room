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
        yield return new WaitForSeconds(1f);
        cannon.SetActive(true);
    }
}
