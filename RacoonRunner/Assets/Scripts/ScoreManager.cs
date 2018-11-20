﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public int score;
    public Text scoreDisplay;

	private void Update () {
        scoreDisplay.text = score.ToString();
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Acorn") && gameObject.CompareTag("Player")) {
            score++;
            Debug.Log(score);
        }
    }
}
