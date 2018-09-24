using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomCounter : MonoBehaviour {

    public static int room = 1;
    Text counter;
	// Use this for initialization
	void Start () {
        counter = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        counter.text = "Room #" + room;
	}
}
