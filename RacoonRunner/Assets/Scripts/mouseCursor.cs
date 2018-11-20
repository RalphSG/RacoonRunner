using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseCursor : MonoBehaviour {

    //public GameObject trailEffect;

    // Update is called once per frame
    void Update () {
        Cursor.visible = false;
        transform.position = Input.mousePosition;
        // Particle effects as a trails for the mouse won't work because they are not rendered over the UI
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Instantiate(trailEffect, transform.position, Quaternion.identity);
        //}
    }
}
