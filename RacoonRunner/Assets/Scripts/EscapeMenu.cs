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

    public GameObject mouseCursor;

    public GameObject pausePanelObject;

    // Use this for initialization
    void Start () {
        pausePanel = gameObject.GetComponent<Image>().color;
        pausePanel.a = 0f;
        pausePanelObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape) && escapeMenuCondition.CompareTag("Player")) {
            if (isPaused) {
                Resume();
            } else {
                Pause();
            }
            mouseCursor.SetActive(isPaused);
            Cursor.visible = false;
        }
	}

    public void Resume() {
        isPaused = false;
        pausePanelObject.SetActive(isPaused);
        pausePanel.a = 0f;
        gameObject.GetComponent<Image>().color = pausePanel;
        transitionAnim.SetBool("paused", isPaused);
        Time.timeScale = 1f;
    }

    void Pause() {
        isPaused = true;
        pausePanelObject.SetActive(isPaused);
        pausePanel.a = 0.7f;
        gameObject.GetComponent<Image>().color = pausePanel;
        transitionAnim.SetBool("paused", isPaused);
        Time.timeScale = 0f;
    }
}
