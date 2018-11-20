using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameprod : MonoBehaviour {

    public Animator transitionAnim;
    public string sceneName1;

    // Use this for initialization
    void Start () {
        StartCoroutine(LoadScene1());
    }

    IEnumerator LoadScene1()
    {
        yield return new WaitForSeconds(2f);
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.1f);
        SceneManager.LoadScene(sceneName1);
    }
}
