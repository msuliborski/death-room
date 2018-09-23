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
    public AudioClip smash;

    public GameObject start;

    AudioSource source;

    bool isDead;

    private void Start()
    {
        source = GetComponent<AudioSource>();
        
    }

    private void Update() {
        if(isDead) enableResetGame();
    }
    
    public void Kaboom()
    {
        Instantiate(leg1, transform.position, Quaternion.identity);
        Instantiate(leg2, new Vector3(transform.position.x-2, transform.position.y, transform.position.z), Quaternion.identity);
        Instantiate(blood, transform.position, Quaternion.identity);
        transform.position = new Vector2(100, 100);
        isDead = true;
    }

    public void Lazers()
    {
        Instantiate(laserCut, transform.position, Quaternion.identity);
        Instantiate(blood, transform.position, Quaternion.identity);
        transform.position = new Vector2(100, 100);
        isDead = true;
    }

    public void Smash()
    {
        Instantiate(blood, transform.position, Quaternion.identity);
        source.clip = smash;
        source.PlayOneShot(source.clip);
        
        transform.position = new Vector2(100, 100);
        isDead = true;
    }

    public void Fall()
    {
        transform.position = new Vector2(100, 100);
        isDead = true;
    }

    public void shot()
    {
        Instantiate(_shot, transform.position, Quaternion.identity);
        Instantiate(blood, transform.position, Quaternion.identity);
        transform.position = new Vector2(100, 100); 
        isDead = true;
    }

    void enableResetGame(){
        //opcja resetu na przycisk?
        start.SetActive(true);

        if(Input.GetKeyDown(KeyCode.H)) {
            start.SetActive(false);
            isDead = false;
            
            transform.position = new Vector2(1.658f, 2.204f);
            //tilesPlacement.restoreTiles();
            TilesPlacemant.restoreTiles();
            //reset punktacji w gui

        }   
    }

}

