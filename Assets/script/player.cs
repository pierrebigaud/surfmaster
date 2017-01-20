using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    Rigidbody2D SurfPhysicsBody2D;

	// Use this for initialization
	void Start () {
        SurfPhysicsBody2D = transform.GetComponent<Rigidbody2D>();
        SurfPhysicsBody2D.AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
    }
	
	// Update is called once per frame
	void Update () {
        
    }
}
