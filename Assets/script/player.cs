using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    Rigidbody2D surfPhysicsBody2D;
    public float vitesse;
    float inputDir;

    // Use this for initialization
    void Start () {
        surfPhysicsBody2D = transform.GetComponent<Rigidbody2D>();
        surfPhysicsBody2D.AddForce(new Vector2(20, 0), ForceMode2D.Impulse);
    }
	
	// Update is called once per frame
	void Update () {
        float rotation=
        inputDir = (float)Input.GetAxisRaw("Horizontal");
        if (inputDir!=0)
        {
            surfPhysicsBody2D.AddTorque(-inputDir/2);
            surfPhysicsBody2D.AddRelativeForce(new Vector2((surfPhysicsBody2D.velocity.x/-inputDir)/2f, (surfPhysicsBody2D.velocity.y / -inputDir) / 2f));
            //surfPhysicsBody2D.velocity.Set(Mathf.Abs(transform.rotation.z * surfPhysicsBody2D.velocity.x), Mathf.Abs(transform.rotation.z * surfPhysicsBody2D.velocity.y));
        }
    }
}
