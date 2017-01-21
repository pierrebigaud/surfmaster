using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawnScript : MonoBehaviour {
	static int MAXBORDERLIMIT = 50;
	static int MINBORDERLIMIT = -MAXBORDERLIMIT;
	static int MAXWAVES = 100;

	public float spawnWait = 1;

    public GameObject Wave;
	public Quaternion SpawnQuat = new Quaternion(); 

	void Start() {
		QuickStart();
		StartCoroutine(SpawnWaves());
	}

	Vector3 RandomPost() {
		Vector3 toReturn = new Vector3 (Random.Range(MINBORDERLIMIT,MAXBORDERLIMIT),Random.Range(MINBORDERLIMIT,MAXBORDERLIMIT),0);
		//toReturn = Random.insideUnitCircle * 5;
		return toReturn;
	}

	IEnumerator SpawnWaves(){
		for (int i = 0; i < MAXWAVES; i++) {
			Instantiate (Wave, RandomPost (), SpawnQuat);
			yield return new WaitForSeconds(spawnWait/5);
		}
	}

	void QuickStart(){
		for (int i = 0; i < MAXWAVES; i++) {
			Instantiate (Wave, RandomPost (), SpawnQuat);

		}
	
	
	}
}
