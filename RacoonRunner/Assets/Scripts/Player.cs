using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    private Vector2 targetPos;
    private Vector2 effectPos;

    public GameObject walkingEffect;
    public Animator[] anim;

    public float speed;
    public float Yincrement;
    public float maxHeight;
    public float minHeight;
    public int health = 3;

    public GameObject moveSound;

    public GameObject gameOver;

    public GameObject moveRestriction;

    public Text healthDisplay;

    // Update is called once per frame
    void Update () {

		effectPos = new Vector2(transform.position.x, transform.position.y - 3.9f);

        healthDisplay.text = health.ToString();

        if (health <= 0)
        {
            for (int i = 0; i < anim.Length; i++)
            {
                anim[i].SetTrigger("Gameover");
            }
            gameObject.tag = "InvinsiblePlayer";
            gameOver.SetActive(true);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else
        {

            transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

            if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight && moveRestriction.activeSelf == false)
            {
                Instantiate(moveSound, effectPos, Quaternion.identity);
                Instantiate(walkingEffect, effectPos, Quaternion.Euler(180, 0, 180));
                targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight && moveRestriction.activeSelf == false)
            {
                Instantiate(moveSound, effectPos, Quaternion.identity);
                Instantiate(walkingEffect, effectPos, Quaternion.Euler(180, 0, 180));
                targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
            }
        }
    }
}
