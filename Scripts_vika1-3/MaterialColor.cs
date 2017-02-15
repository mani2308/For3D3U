using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialColor : MonoBehaviour {
    
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.R))
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
            Debug.Log("boltalit breytt í rauðan");
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
            Debug.Log("boltalit breytt í bláan");
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
            Debug.Log("boltalit breytt í grænan");
        }
        // B = blár
        // G = grænn
    }
}
