using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBall : MonoBehaviour {
    public float myTimer = 3f; // tími sem líður fram að sprengingu
    public GameObject myExplosion; // sprenging sem spilast
    
	// Update is called once per frame
	void Update () {
        myTimer -= Time.deltaTime; /* deltaTime hverju sinni
        er fjöldi millisek sem liðu frá því síðast var kallað
        á deltaTime */

        if(myTimer <= 0)
        {
            GameObject bomb;
            bomb = Instantiate(myExplosion, transform.position,
                Quaternion.identity) as GameObject;
            Destroy(this.gameObject);
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        GameObject bomb;
        bomb = Instantiate(myExplosion, transform.position,
            Quaternion.identity) as GameObject;
        Destroy(this.gameObject);
    }
}
