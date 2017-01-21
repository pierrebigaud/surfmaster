using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveBehaviour : MonoBehaviour{
	
    static public float SpeedAdjust = 5;

    public float tumble;
    public float Speed;

    // Use this for initialization
    void Start()
    {
        this.Speed = Random.value * SpeedAdjust;
        this.GetComponent<Rigidbody>().velocity = Random.insideUnitCircle * this.Speed;
    }

    // Update is called once per frame
    void Update(){
		this.GetComponent<Rigidbody>().angularVelocity = new Vector3 ();
    }
}
