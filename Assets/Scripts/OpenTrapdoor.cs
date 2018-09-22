using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTrapdoor : MonoBehaviour
{
    public GameObject hole;
    public GameObject frame;
    public float moveSpeed = 0.1f;
    public float offset = 0.1f;
    Vector2 tempHole;
    bool flag = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (frame.transform.localScale.y > (tempHole.y + offset)) //open Vertically
        {
            OpenV();
        }
        else flag = true;

        if ((frame.transform.localScale.x > (tempHole.x + offset)) && flag == true) //open Horinzotally
            OpenH();
    }

    Vector2 OpenV()
    {
        tempHole = hole.transform.localScale;
        tempHole.y += 0.1f * moveSpeed;
        hole.transform.localScale = tempHole;

        return tempHole;
    }

    Vector2 OpenH()
    {
        tempHole = hole.transform.localScale;
        tempHole.x += 0.1f * moveSpeed;
        hole.transform.localScale = tempHole;

        return tempHole;
    }
}