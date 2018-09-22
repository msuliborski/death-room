using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilesPlacemant : MonoBehaviour {

	public GameObject Floor;
	public GameObject empty;
	public GameObject rocket;
	public GameObject trap;
	public GameObject press;
	public GameObject spikes;
	public GameObject machinegun;
	public GameObject laser;

	
	Vector2 offset = new Vector2(1.22f, -0.1f);

	void Start () {
		
		positions = new List<Vector2>();

		
		spawnTiles();
	}

	void Update() {
		
	}

	void spawnTiles(){

		float randomVer = (float)((int)((Random.Range(0, 3)))*1.2 + 0.6);
		for(float j = 4.2f; j > -0.6f; j -= 1.2f){
			for(float i = 0.6f; i < 12.6f; i += 2.4f){
				GameObject d = Instantiate(empty, new Vector2(i, j) + offset, Quaternion.identity);
				d.transform.SetParent(Floor);
			}
			for(float i = 1.8f; i < 10.2f; i += 2.4f){
				if(randomVer >= (j-0.2) && randomVer <= (j+0.2)) Instantiate(empty, new Vector2(i, randomVer) + offset, Quaternion.identity);
				else Instantiate(getRandomTile(), new Vector2(i, j) + offset, Quaternion.identity);
				
			}
		}

		// for (float i = 1.8f; i < 10.2f; i += 1.2f){
		// 	for(float j = 4.2f; j > -0.6f; j -= 1.2f){
		// 		if ((i-0.6) % 1.2 == 0) {Instantiate(empty, new Vector2(i, j) + offset, Quaternion.identity); continue;}
		// 		//positions.Add(new Vector2(i, j));
		// 	}
		// }
		
	}

	GameObject getRandomTile() {
		int randomNum = (int) (Random.Range(1, 7));
		GameObject randomTile;
		switch(randomNum){
			case 1: return empty;
			case 2: return rocket; 
			case 3: return trap; 
			case 4: return press;
			case 5: return spikes;
			case 6: return machinegun;
			case 7: return laser;
		}
		return empty;
	}
}
