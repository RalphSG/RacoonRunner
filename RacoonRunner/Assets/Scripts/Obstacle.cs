using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

    public int damage = 1;
    public float speed;

    public GameObject effect;

    public GameObject destructionSound;
    public GameObject hitSound;

    private Shake shake;

    private void Start()
    {
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>();
    }

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other) {

        if (other.CompareTag("Player")) {

            Instantiate(destructionSound, transform.position, Quaternion.identity);
            Instantiate(effect, transform.position, Quaternion.identity);
            other.GetComponent<Player>().health -= damage;
            Debug.Log(other.GetComponent<Player>().health);
            if (gameObject.CompareTag("Obstacle")) {
                Instantiate(hitSound, transform.position, Quaternion.identity);
                shake.CamShake();
            }
            Destroy(gameObject);
        }
    }


}
