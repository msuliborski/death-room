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
   

    public static List<GameObject> deadBodies = new List<GameObject>();

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
        //deadBodies.Add(Instantiate(leg1, transform.position, Quaternion.identity));
        //deadBodies.Add(Instantiate(leg2, new Vector3(transform.position.x-2, transform.position.y, transform.position.z), Quaternion.identity));
        deadBodies.Add(Instantiate(blood, transform.position, Quaternion.identity));
        transform.position = new Vector2(100, 100);
        isDead = true;
        DeathCounter.score++;
        
    }

    public void Lazers()
    {
        //deadBodies.Add(Instantiate(laserCut, transform.position, Quaternion.identity));
        deadBodies.Add(Instantiate(blood, transform.position, Quaternion.identity));
        transform.position = new Vector2(100, 100);
        isDead = true;
        DeathCounter.score++;
    }

    public void Smash()
    {
        deadBodies.Add(Instantiate(blood, transform.position, Quaternion.identity));
        source.clip = smash;
        source.PlayOneShot(source.clip);
        
        transform.position = new Vector2(100, 100);
        isDead = true;
        DeathCounter.score++;
    }

    public void Fall()
    {
        transform.position = new Vector2(100, 100);
        isDead = true;
        DeathCounter.score++;
    }

    public void shot()
    {
        //deadBodies.Add(Instantiate(_shot, transform.position, Quaternion.identity));
        deadBodies.Add(Instantiate(blood, transform.position, Quaternion.identity));
        transform.position = new Vector2(100, 100); 
        isDead = true;
        DeathCounter.score++;
    }

    void enableResetGame(){
        //opcja resetu na przycisk?
        start.SetActive(true);
        

        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.Space)) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow)) {
            start.SetActive(false);
            isDead = false;
            
            transform.position = new Vector2(1.5f, 2.2f);
            //tilesPlacement.restoreTiles();
            TilesPlacemant.restoreTiles();
            //reset punktacji w gui

        }   
    }

    public static void deleteDeadBodies(){
        for(int i = 0; i < deadBodies.Count; i++)
            Destroy(deadBodies[i]);
        deadBodies = new List<GameObject>(); 
    }

}

