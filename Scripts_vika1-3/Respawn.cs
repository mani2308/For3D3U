using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {
    public float deathHeight = 48f;
    private bool isDead = false;
    private Vector3 respawnPosition;

	// Use this for initialization
	void Start ()
    {
        respawnPosition = transform.position;
	}

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.collider.gameObject.tag == "water")
            isDead = true;
    }

    // Update is called once per frame
    void Update ()
    {
        if((transform.position.y <= deathHeight) || (isDead))
        {
            transform.position = respawnPosition;
            isDead = false;
        }
		
	}
    public void UpdatePosition(Vector3 newLocation)
    {
        respawnPosition = newLocation;
        Debug.Log("komin ný staðsetning");
    }
}
