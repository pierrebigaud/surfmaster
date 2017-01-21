using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour {

    Rigidbody2D surfPhysicsBody2D;
    public float vitesseY;
    public Sprite[] surfeurSpriste;
    public float vitesseX;
    public static float vitesseMax=200;
    public float rotationRoulette=0;
    public static int rS;
    public Text speedText;
    float inputDir;

    // Use this for initialization
    void Awake () {
        transform.GetComponent<SpriteRenderer>().sprite = surfeurSpriste[0];
    }
    void Start()
    {
        surfPhysicsBody2D = transform.GetComponent<Rigidbody2D>();
        surfPhysicsBody2D.AddForce(new Vector2(20, 0), ForceMode2D.Impulse);
        speedText = GameObject.Find("speed").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update () {
        inputDir = (float)Input.GetAxisRaw("Horizontal");
        if (inputDir!=0)
        {
            if (surfPhysicsBody2D.velocity.x < -vitesseMax)
            {
                vitesseX = -vitesseMax;
            }
            else if (surfPhysicsBody2D.velocity.x > vitesseMax)
            {
                vitesseX = vitesseMax;
            }
            else
            {
                vitesseX = surfPhysicsBody2D.velocity.x;
            }
            if (surfPhysicsBody2D.velocity.x < -vitesseMax)
            {
                vitesseY = -vitesseMax;
            }
            else if (surfPhysicsBody2D.velocity.y > vitesseMax)
            {
                vitesseY = vitesseMax;
            }
            else
            {
                vitesseY = surfPhysicsBody2D.velocity.y;
            }

            speedText.text = "SPEED: "+(int)(vitesseY+vitesseX);
            surfPhysicsBody2D.AddTorque(-inputDir / 2);
            surfPhysicsBody2D.AddRelativeForce(new Vector2((vitesseX / -inputDir)/2f, (vitesseY / -inputDir) / 2f));
            //surfPhysicsBody2D.velocity.Set(Mathf.Abs(transform.rotation.z * surfPhysicsBody2D.velocity.x), Mathf.Abs(transform.rotation.z * surfPhysicsBody2D.velocity.y));
        }
    }
}
