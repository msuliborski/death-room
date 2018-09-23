using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goTo : MonoBehaviour {

    void Update () {
         if(Input.GetMouseButton(0))
             Application.LoadLevel(1);
     }
}
