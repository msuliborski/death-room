using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerConroller : MonoBehaviour {
    
    private DeathManager dm;
    public GameObject player;
    public GameObject blood;
    public GameObject leg1;
    public GameObject leg2;
    public GameObject laserCut;
    public GameObject _shot;

    
    public void Kaboom()
    {
        Instantiate(leg1, transform.position, Quaternion.identity);
        Instantiate(leg2, new Vector3(transform.position.x-2, transform.position.y, transform.position.z), Quaternion.identity);
        Instantiate(blood, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    public void Lazers()
    {
        Instantiate(laserCut, transform.position, Quaternion.identity);
        Instantiate(blood, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    public void Smash()
    {
        Instantiate(blood, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    public void Fall()
    {
        Destroy(gameObject);
    }

    public void shot()
    {
        Instantiate(_shot, transform.position, Quaternion.identity);
        Instantiate(blood, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}

