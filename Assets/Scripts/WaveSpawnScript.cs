using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawnScript : MonoBehaviour {

    public GameObject Wave;
	public Quaternion SpawnQuat = new Quaternion(); 

	void Start() {
		SpawnWaves();
	}

	Vector3 RandomPost() {
		Vector3 toReturn = new Vector3 ();
		toReturn = Random.insideUnitCircle * 5;
		return toReturn;
	}

	void SpawnWaves(){
		Instantiate(Wave, RandomPost(),SpawnQuat);
		Instantiate(Wave, RandomPost(),SpawnQuat);
		Instantiate(Wave, RandomPost(),SpawnQuat);
		Instantiate(Wave, RandomPost(),SpawnQuat);
		Instantiate(Wave, RandomPost(),SpawnQuat);
	}
}
