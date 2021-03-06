﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimShoot : MonoBehaviour {

    public GameObject Bullet;
    public GameObject SpawnPoint;
    public GameObject Player;

    public float firerate = 2f;
    public float velocity = 15f;
    public float rotationOffset = 0.4f;
    public float ammunition = 10;

    bool flag = true;
    bool isTriggered = false;
    
    public SpriteRenderer spriteRenderer;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

        aim();
  	}

void aim()
{
    Vector2 direction = (Player.transform.position - transform.position);
    float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

    Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotationOffset);

    if (flag && ammunition >= 0)
    {
        direction.Normalize();
        GameObject shot = (GameObject)Instantiate(Bullet, SpawnPoint.transform.position, Quaternion.identity);
        shot.GetComponent<Rigidbody2D>().velocity = transform.right * velocity;
        StartCoroutine(Cooldown(1));
        Destroy(shot, 5);
        ammunition--;
    }
}
    IEnumerator Cooldown(float time)
    {
        flag = false;
        yield return new WaitForSeconds(time);
        flag = true;
    }
}
