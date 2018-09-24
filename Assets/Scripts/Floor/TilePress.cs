using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilePress : MonoBehaviour {

    
    public GameObject wallUp;
    public GameObject wallDown;
    int flag = 0;

    bool isTriggered = false;
 	SpriteRenderer spriteRenderer;
    GameObject player;

    void Start(){
        spriteRenderer = GetComponent<SpriteRenderer>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update () {        
		if (Mathf.Abs((transform.position - player.transform.position).magnitude) < 50)
            spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, TileEmpty.getAlphaRatio(transform.position));
        if (flag == 1){
            wallUp.transform.position = new Vector2(wallUp.transform.position.x, wallUp.transform.position.y - 0.5f);
            wallDown.transform.position = new Vector2(wallDown.transform.position.x, wallDown.transform.position.y + 0.5f);
        }
        else if (flag == -1){
            StartCoroutine(Cooldown());
            wallUp.transform.position = new Vector2(wallUp.transform.position.x, wallUp.transform.position.y + 0.5f);
            wallDown.transform.position = new Vector2(wallDown.transform.position.x, wallDown.transform.position.y - 0.5f);
        }
        

    }

    void OnTriggerEnter2D(Collider2D _colliderPlayer){
        
        spriteRenderer.color = Color.red;

        if (!isTriggered)
        {
            isTriggered = true;
            flag = 1;
            
            
        }

    }
    IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(0.8f);
        flag = 0;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Press") flag = -1;
    }
}