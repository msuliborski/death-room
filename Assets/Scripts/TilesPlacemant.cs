using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilesPlacemant : MonoBehaviour {

	public static int level = 1;
	static float lastTileX =  0;

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
	public static GameObject door;
	public static GameObject wall;
	
	public static Vector2 offset = new Vector2(1.22f, -0.1f);

	public static GameObject doorOBJ;
	static Vector2 doorPos;

	public static GameObject wallOBJ;
	static Vector2 wallPos;

	void Start() {
		calculateLevelLength();
		getObj();
		spawnTiles();
	}

	void Update() {
		calculateLevelLength();
	}

	public static void spawnTiles(){
		PlayerConroller.deleteDeadBodies();
		destroyDisplayedTiles();
		destroyBackupTiles();
		getObj();
		for(float i = 0.6f; i < lastTileX+1; i += 2.4f){
			for(float j = 4.2f; j > -0.6f; j -= 1.2f){
				displayedTiles.Add(Instantiate(empty, new Vector2(i, j) + offset, Quaternion.identity));
			}
		}

		for(float i = 1.8f; i < lastTileX+1; i += 2.4f){	
			float randomVer = (float)((int)((Random.Range(0, 3)))*1.2 + 0.6);
			for(float j = 4.2f; j > -0.6f; j -= 1.2f){
				if(randomVer >= (j-0.2) && randomVer <= (j+0.2)) {
					displayedTiles.Add(Instantiate(empty, new Vector2(i, j) + offset, Quaternion.identity));
					tilesBackup.Add(empty);
				} else {
					GameObject g = getRandomTile();
					displayedTiles.Add(Instantiate(g, new Vector2(i, j) + offset, Quaternion.identity));
					tilesBackup.Add(g);
				}
			}
		}
		Debug.Log(tilesBackup.Count);
		doorOBJ = Instantiate(door, doorPos, Quaternion.identity);
		wallOBJ = Instantiate(wall, wallPos, Quaternion.identity);
	}
	
	public static void restoreTiles(){
		destroyDisplayedTiles();
		getObj();
		for(float i = 0.6f; i < lastTileX+1; i += 2.4f){
			for(float j = 4.2f; j > -0.6f; j -= 1.2f){
				displayedTiles.Add(Instantiate(empty, new Vector2(i, j) + offset, Quaternion.identity));
			}
		}

		int k = 0;
		for(float i = 1.8f; i < lastTileX+1; i += 2.4f){
			for(float j = 4.2f; j > -0.6f; j -= 1.2f){
				displayedTiles.Add(Instantiate(tilesBackup[k++], new Vector2(i, j) + offset, Quaternion.identity));
			}
		}
		doorOBJ = Instantiate(door, doorPos, Quaternion.identity);
		wallOBJ = Instantiate(wall, wallPos, Quaternion.identity);
	}

	public static void destroyDisplayedTiles(){
		for(int i = 0; i < displayedTiles.Count; i++){
			Destroy(displayedTiles[i]);
		}
		displayedTiles = new List<GameObject>();
		Destroy(doorOBJ);
		Destroy(wallOBJ);
	}
	

	public static void destroyBackupTiles(){
		tilesBackup = new List<GameObject>();
	}

	public static void getObj(){
		empty = GameObject.Find("/unityjestchujowe/TileEmpty");
		rocket = GameObject.Find("/unityjestchujowe/TileRocket");
		trap = GameObject.Find("/unityjestchujowe/TileTrap");
		press = GameObject.Find("/unityjestchujowe/TilePress");
		spikes = GameObject.Find("/unityjestchujowe/TileSpikes");
		machinegun = GameObject.Find("/unityjestchujowe/TileMachineGun");
		laser = GameObject.Find("/unityjestchujowe/TileLaser");
		door = GameObject.Find("/unityjestchujowe/doorExit");
		wall = GameObject.Find("/unityjestchujowe/wall");
	}

	public static void calculateLevelLength(){
		lastTileX = (float)(0.6 + (level + 3) * 1.2);
		doorPos = new Vector2(lastTileX + 2, 3.24f);
		wallPos = new Vector2(lastTileX + 2.25f, 2.48f);
	}

	static GameObject getRandomTile() {
		int randomNum = (int) (Random.Range(1, 7.49f));
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
