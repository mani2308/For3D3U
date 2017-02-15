using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectedInfo : MonoBehaviour {
    int CollectedAmmo = 0;
    public Text CounterText;

	// Use this for initialization
	public void ShowCount(int Count)
    {
        Debug.Log("Ammo: " + CollectedAmmo);
        CollectedAmmo = Count;
        CounterText.text = "Bombs: " + CollectedAmmo.ToString();
    }
}
