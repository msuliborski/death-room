using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilePress : MonoBehaviour {

    PlayerConroller playerController;
    public GameObject wallUp;
    public GameObject wallDown;
    int flag = 0;

    bool isTriggered = false;
 	SpriteRenderer spriteRenderer;

    void Start(){
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update () {
           if (flag == 1)
           {
               wallUp.transform.position = new Vector2(wallUp.transform.position.x, wallUp.transform.position.y - 0.5f);
               wallDown.transform.position = new Vector2(wallDown.transform.position.x, wallDown.transform.position.y + 0.5f);
           }
           else if (flag == -1)
           {
               wallUp.transform.position = new Vector2(wallUp.transform.position.x, wallUp.transform.position.y + 0.5f);
               wallDown.transform.position = new Vector2(wallDown.transform.position.x, wallDown.transform.position.y - 0.5f);
           }
       }

    void OnTriggerEnter2D(Collider2D _colliderPlayer){
        spriteRenderer.color = Color.blue;

        if (!isTriggered)
        {
            isTriggered = true;
            flag = 1;
            StartCoroutine(Cooldown());
            //playerController.Smash();
        }

    }
    IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(0.25f);
        flag = -1;
        yield return new WaitForSeconds(0.25f);
        flag = 0;
    }
}