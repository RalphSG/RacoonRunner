using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

    public Animator transitionAnim;
    public bool rPressed;

    public GameObject deathSound;
    public bool deathSoundBool;

    public GameObject mouseCursor;

    public string scene1;

    private void Start()
    {
        gameObject.SetActive(false);
        rPressed = false;
    }

    // Update is called once per frame
    void Update () {
        if (Time.timeScale == 1f && rPressed == false){
            StartCoroutine(FreezeGame());
        }
        if (gameObject.activeSelf == true && deathSoundBool == false)
        {
            Instantiate(deathSound, transform.position, Quaternion.identity);
            deathSoundBool = true;
        }
        if (gameObject.activeSelf) {
            mouseCursor.SetActive(true);
        }
	}

    public void RestartPressed()
    {
            StopAllCoroutines();
            rPressed = true;
            StartCoroutine(ReloadScene(1f));
    }

    public void GoToMenu()
    {
        StopAllCoroutines();
        rPressed = true;
        StartCoroutine(LoadMenu(1f));
    }

    IEnumerator ReloadScene(float waitTime)
    {
        //Debug.Log("Starting animation");
        transitionAnim.SetTrigger("end");
        //Debug.Log("Time will come back in waitTime-seconds");
        yield return new WaitForSecondsRealtime(waitTime);
        //Debug.Log("I finished waiting");
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    IEnumerator LoadMenu(float waitTime)
    {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSecondsRealtime(waitTime);
        Time.timeScale = 1f;
        SceneManager.LoadScene(scene1);
    }

    IEnumerator FreezeGame()
    {
        //Debug.Log("FreezeGame is starting.");
        yield return new WaitForSeconds(1.7f);
        Time.timeScale = 0f;
    }
}
