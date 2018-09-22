using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trapdoor : MonoBehaviour
{

    public GameObject trapdoor;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(Trap());
    }

    IEnumerator Trap()
    {
        yield return new WaitForSeconds(0.2f);
        trapdoor.SetActive(true);
    }
}
