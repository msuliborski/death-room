using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor_Tile : MonoBehaviour
{

    SpriteRenderer m_SpriteRenderer;
    Color m_NewColor;
    float m_Red, m_Blue, m_Green;

    // Use this for initialization
    void Start()
    {
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        renderer.color = new Color(255f, 57f, 0f, 255f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}