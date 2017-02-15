using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
    [SerializeField]
    private float timeLeft = 20.0f;
	public Text TimeText;

	void Start () {
		ShowTime ();
	}
	
	// Update is called once per frame
	void Update () {	
		if (timeLeft < 0) {
			GetComponent<GameOver> ().GameFinished (false);
		}
		ShowTime ();
	}

	void ShowTime(){
		TimeText.text = "Tími eftir: " + Mathf.Ceil(timeLeft).ToString() + " sek";
	}
}
