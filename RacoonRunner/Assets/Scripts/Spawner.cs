﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject[] obstaclePatterns;

    private float timeBtwSpawn;
    public float startTimeBtwaSpawn;
    public float decreaseTime;
    public float minTime = 0.65f;
	
	private void Update () {

        if (timeBtwSpawn <= 0) {

            int rand = Random.Range(0, obstaclePatterns.Length);
            Instantiate(obstaclePatterns[rand], transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwaSpawn;
            if (startTimeBtwaSpawn > minTime) {
                startTimeBtwaSpawn -= decreaseTime;
            }
        }
        else {
            timeBtwSpawn -= Time.deltaTime;
        }
	}
}
