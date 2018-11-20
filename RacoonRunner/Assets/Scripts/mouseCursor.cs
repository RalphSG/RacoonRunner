using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseCursor : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
        Cursor.visible = false;
        transform.position = Input.mousePosition;
	}
}
