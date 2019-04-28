using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScreenManager : MonoBehaviour {

	public static int score;

	Text text;

	// Use this for initialization
	void Start () {
		text = GetComponent <Text> ();
		score = 100;
		text.gameObject.SetActive (true);
		//		Invoke ("WakeUp", 2);
	}

	// Update is called once per frame
	void Update () {
		Debug.Log("hi");
		text.text = "Score: " + ScoreManager.score;
	}

	//	void WakeUp() {
	//		text.gameObject.SetActive (true);
	//	}
}
