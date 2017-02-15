using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingBlock : MonoBehaviour {
    public float speed = 10f;
    
	// Update is called once per frame
	void Update () {
		if(gameObject.tag == "TheTarget")
        {
            transform.Rotate(Vector3.forward, 
                speed * Time.deltaTime);
        }
        else
        {
            transform.Rotate(Vector3.up,
                speed * Time.deltaTime);
        }
	}
}
