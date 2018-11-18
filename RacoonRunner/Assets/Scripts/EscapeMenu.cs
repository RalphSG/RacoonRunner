﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EscapeMenu : MonoBehaviour {

    public GameObject escapeMenu;
    public static bool isPaused = false;

    public Animator transitionAnim;
    private Color pausePanel;

    // Use this for initialization
    void Start () {
        pausePanel = gameObject.GetComponent<Image>().color;
        pausePanel.a = 0f;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (isPaused) {
                Resume();
            } else {
                Pause();
            }
        }
	}

    void Resume() {
        isPaused = false;
        pausePanel.a = 0f;
        gameObject.GetComponent<Image>().color = pausePanel;
        transitionAnim.SetBool("paused", isPaused);
        Time.timeScale = 1f;
    }

    void Pause() {
        isPaused = true;
        pausePanel.a = 0.7f;
        gameObject.GetComponent<Image>().color = pausePanel;
        transitionAnim.SetBool("paused", isPaused);
        Time.timeScale = 0f;
    }
}
