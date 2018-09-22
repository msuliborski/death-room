using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileLauncher : MonoBehaviour {

    public GameObject missile;
	// Use this for initialization
	void Start () {
        StartCoroutine(Launch());
	}
	
	IEnumerator Launch()
    {
        yield return new WaitForSeconds(1f);
        missile.SetActive(true);
    }
}
