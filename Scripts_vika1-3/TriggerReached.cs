using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerReached : MonoBehaviour {
    /* Script sem er virkjað um leið og eitthvað fer inn í triggersvæði þess hluts
     * sem scriptið tilheyrir.
     * Haka verður við að þessi hlutur sé trigger.
     * Getum nálgast tag þess hlutar sem fór inn í triggerinn.
     */ 
	
    void OnTriggerEnter(Collider otherObj)
    {
        Debug.Log("klessti á!");
        if(otherObj.tag == "Player")
        {
            // uppfæra respawn position á player
            otherObj.GetComponent<Respawn>().UpdatePosition(transform.position);
        }
    }
    /*
     OnTriggerEnter(Collider otherObj) {}
     OnTriggerStay(Collider otherObj) {}
     OnTriggerExit(Collider otherObj) {}
     */
}
