using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBall : MonoBehaviour {
    public int speed = 30; // hversu hratt er kastað
    public Rigidbody ball; // hluturinn VERÐUR að vera rigidbody
    public Transform startLocation; // hvaðan á að kasta
    
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown ("Fire1"))
        {
            throwBall();
        }
	}
    void throwBall()
    {
        // búa til boltann
        Rigidbody currentBall;
        currentBall = Instantiate(ball, startLocation.position,
            Quaternion.identity) as Rigidbody;
        currentBall.AddRelativeForce(transform.forward * speed,
            ForceMode.Impulse);

        // látum þessa tvo colliders (ball og transfer)
        // ignora hvorn annan
        Physics.IgnoreCollision(currentBall.GetComponent<Collider>(),
            transform.root.GetComponent<Collider>());
    }
}
