using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DeathManager : MonoBehaviour {

    public int deaths = 0;
    public Text deathText;

    public void IncreaseDeaths()
    {
        deaths += 1;
        deathText.text = deaths.ToString();
    }
}
