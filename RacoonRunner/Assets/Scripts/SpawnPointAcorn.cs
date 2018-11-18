using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointAcorn : MonoBehaviour {

    public GameObject acorn;
    public int acornSpawnChance;

    void Start()
    {
        int rand = Random.Range(0, acornSpawnChance);
        if (rand == 0) {
            Instantiate(acorn, transform.position, Quaternion.identity);
        }
    }
}
