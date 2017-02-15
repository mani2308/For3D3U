using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCollision : MonoBehaviour
{
    /* script sem eykur ammocount hjá player svo hann geti 
     * kastað sprengjum. Eyðir hlutnum þegar búið er að rekast
     * á hann. Spilar hljóð við "árekstur"
     */

    public AudioClip bling;
    public GameObject GE;
    public int AmmoCount;


	// Use this for initialization
	void Start () {
        AmmoCount = 0;
        ShowCount();

    }
    /* Þessi function þarf að vera á fpc og skynjar þegar hann rekst á 
     * collider af einhverjum öðrum hlut, grípur upplýsingarnar
     * frá hlutnum sem hann rakst á, setur þær í hit variable sem við
     * getum svo unnið með.
     * 
     * Ef þið viljið snúa þessu við og hafa scriptuna á hlutnum sjálfum,
     * þá skal nota OnCollisionEnter(Collision hit) { ... }
     */
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.collider.gameObject.tag == "AmmoBox")
        {
            GetComponent<AudioSource>().PlayOneShot(bling);
            AmmoCount = AmmoCount + 8;
            hit.gameObject.SetActive(false); // hlutur falinn
            ShowCount();
        }
    }
    void ShowCount()
    {
        Debug.Log("AmmoCount: " + AmmoCount);
        GE.GetComponent<CollectedInfo>().ShowCount(AmmoCount);
    }
}
