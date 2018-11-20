using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EscapeMenu : MonoBehaviour {

    public GameObject escapeMenu;
    public GameObject escapeMenuCondition;
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
        if (Input.GetKeyDown(KeyCode.Escape) && escapeMenuCondition.CompareTag("Player")) {
            if (isPaused) {
                Resume();
            } else {
                Pause();
            }
        }
	}

    public void Resume() {
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
