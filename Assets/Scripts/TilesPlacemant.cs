using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilesPlacemant : MonoBehaviour {

	public static List<GameObject> tilesBackup = new List<GameObject>();
	public static List<GameObject> displayedTiles = new List<GameObject>();

	public GameObject Floor;
	public static GameObject empty;
	public static GameObject rocket;
	public static GameObject trap;
	public static GameObject press;
	public static GameObject spikes;
	public static GameObject machinegun;
	public static GameObject laser;
	
	public static Vector2 offset = new Vector2(1.22f, -0.1f);

	void Start () {
		empty = GameObject.Find("/unityjestchujowe/TileEmpty");
		rocket = GameObject.Find("/unityjestchujowe/TileRocket");
		trap = GameObject.Find("/unityjestchujowe/TileTrap");
		press = GameObject.Find("/unityjestchujowe/TilePress");
		spikes = GameObject.Find("/unityjestchujowe/TileSpikes");
		machinegun = GameObject.Find("/unityjestchujowe/TileMachineGun");
		laser = GameObject.Find("/unityjestchujowe/TileLaser");
		spawnTiles();
	}

	void Update() {
		
	}

	static void spawnTiles(){

		float randomVer = (float)((int)((Random.Range(0, 3)))*1.2 + 0.6);
		for(float j = 4.2f; j > -0.6f; j -= 1.2f){
			for(float i = 0.6f; i < 12.6f; i += 2.4f){
				displayedTiles.Add(Instantiate(empty, new Vector2(i, j) + offset, Quaternion.identity));
			}
			for(float i = 1.8f; i < 10.2f; i += 2.4f){
				if(randomVer >= (j-0.2) && randomVer <= (j+0.2)) {
					displayedTiles.Add(Instantiate(empty, new Vector2(i, randomVer) + offset, Quaternion.identity));
					tilesBackup.Add(empty);
				} else {
					GameObject g = getRandomTile();
					displayedTiles.Add(Instantiate(g, new Vector2(i, j) + offset, Quaternion.identity));
					tilesBackup.Add(g);
				}
			}
		}
	}
	
	public static void restoreTiles(){
		int k = 0;
		for(int i = 0; i < displayedTiles.Count; i++){
			Destroy(displayedTiles[i]);
		}
		displayedTiles = new List<GameObject>();
		for(float j = 4.2f; j > -0.6f; j -= 1.2f){
			for(float i = 0.6f; i < 12.6f; i += 2.4f){
				displayedTiles.Add(Instantiate(empty, new Vector2(i, j) + offset, Quaternion.identity));
			}
			for(float i = 1.8f; i < 10.2f; i += 2.4f, k++){
				displayedTiles.Add(Instantiate(tilesBackup[k], new Vector2(i, j) + offset, Quaternion.identity));
			}
		}

	}
	

	static GameObject getRandomTile() {
		int randomNum = (int) (Random.Range(1, 7));
		GameObject randomTile = empty;
		switch(randomNum){
			case 1: return randomTile;
			case 2: return randomTile = rocket; 
			case 3: return randomTile = trap; 
			case 4: return randomTile = press;
			case 5: return randomTile = spikes;
			case 6: return randomTile = machinegun;
			case 7: return randomTile = laser;
		}
		return randomTile;
	}
}
