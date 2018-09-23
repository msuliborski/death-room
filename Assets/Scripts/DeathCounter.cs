using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathCounter : MonoBehaviour {

    public static int score = 0;
    PlayerConroller playerController;
    Text counter;
	// Use this for initialization
	void Start () {
        counter = GetComponent<Text>();
        playerController = gameObject.GetComponent<PlayerConroller>();
	}
	
	// Update is called once per frame
	void Update () {
        counter.text = "Death #" + score;
	}
}
