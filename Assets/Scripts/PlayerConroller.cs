using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerConroller : MonoBehaviour {
    // Use this for initialization
    private DeathManager dm;

    void Awake()
    {
        dm = GameObject.FindObjectOfType<DeathManager>();
    }

    void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Death()
    {
       Destroy(this);
    }
}

