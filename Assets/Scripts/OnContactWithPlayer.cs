using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnContactWithPlayer : MonoBehaviour {

	void OnTriggerEnter(Collider other){ //It means that the player touches the wave
		if (other.tag == "Player") {
	}
	
	}
}
