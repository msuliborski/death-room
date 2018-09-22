using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerConroller : MonoBehaviour {
    // Use this for initialization
    private DeathManager dm;
    public GameObject player;
    public GameObject blood;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.P)) Death();
	}

	public void Death()
	{
        Instantiate(blood, transform.position, Quaternion.identity);
        player.SetActive(false);
	}
}

