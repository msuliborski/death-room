using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTrap : MonoBehaviour {
    bool isTriggered = false;
    public GameObject machineGun;

    // Use this for initialization
    void Start () {
      
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    void OnTriggerEnter2D(Collider2D _colliderPlayer)
    {
        if (!isTriggered)
        {
            isTriggered = true;
            machineGun.SetActive(true);
        }
    }
}