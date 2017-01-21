using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class gameManager : MonoBehaviour {

    public player player;
    public Text scoreText;
    int score;
    int displayedScore;
    float scoreTime;
    bool Intervallepasse=true;

	// Use this for initialization
	void Start () {
        scoreText = GameObject.Find("score").GetComponent<Text>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<player>();
        Debug.Log("lol");
    }

    // Update is called once per frame
    void FixedUpdate () {
        score += (int)(Mathf.Pow(player.vitesseY, 2) + Mathf.Pow(player.vitesseY, 2)) / 10;
        scoreText.text = "SCORE: " + score;
    }
}
