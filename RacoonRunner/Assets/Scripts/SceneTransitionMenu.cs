using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneTransitionMenu : MonoBehaviour {

	public Animator transitionAnim;
	public string sceneName1;
	public string sceneName2;
	public string sceneName3;
	public string sceneName4;

    public GameObject mouseCursor;

    public GameObject player;

    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "EndlessRunner")
        {
            mouseCursor.SetActive(false);
        }
        Cursor.visible = false;
    }

    public void NewGame(){
		StartCoroutine (LoadScene1());
	}

	IEnumerator LoadScene1(){
		transitionAnim.SetTrigger ("end");
		yield return new WaitForSeconds (1.7f);
		SceneManager.LoadScene (sceneName1);
	}

	public void Menu(){
		StartCoroutine (LoadScene2());
	}

	IEnumerator LoadScene2(){
		transitionAnim.SetTrigger ("end");
        player.tag = "InvinsiblePlayer";
        yield return new WaitForSeconds (1.7f);
		SceneManager.LoadScene (sceneName2);
	}

	public void Options(){
		StartCoroutine (LoadScene3());
	}

	IEnumerator LoadScene3(){
		transitionAnim.SetTrigger ("end");
		yield return new WaitForSeconds (1.7f);
		SceneManager.LoadScene (sceneName3);
	}

	public void Quit(){
		StartCoroutine (LoadScene4());
	}

	IEnumerator LoadScene4(){
		transitionAnim.SetTrigger ("end");
		yield return new WaitForSeconds (1.7f);
        Application.Quit();
	}
}