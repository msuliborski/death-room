using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls : MonoBehaviour {

    public GameObject wallUp;
    public GameObject wallDown;
    int flag = 0;

    void Start()// void OnCollisionEnter2D(Collision2D collision)
    {
        //if (collision.gameObject.layer == 5)
      //  {
            flag = 1;
            StartCoroutine(Cooldown());
       // }
    }

    void Update () {
		if(flag == 1)
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

    IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(0.25f);
        flag = -1;
        yield return new WaitForSeconds(0.25f);
        flag = 0;
    }
}
