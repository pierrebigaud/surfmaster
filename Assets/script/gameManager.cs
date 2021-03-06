﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class gameManager : MonoBehaviour {

    public player player;
    public Text scoreText;
    int score;
    float countdown=1;
    float scoreTime;

	// Use this for initialization
	void Start () {
        scoreText = GameObject.Find("score").GetComponent<Text>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<player>();
    }

    // Update is called once per frame
    void FixedUpdate () {
        countdown -= Time.deltaTime;
        if (countdown <= 0)
        {
            score += (int)(Mathf.Pow(player.vitesseY, 2) + Mathf.Pow(player.vitesseY, 2));
            scoreText.text = "SCORE: " + score;
            countdown = 1;
        }
    }
}
