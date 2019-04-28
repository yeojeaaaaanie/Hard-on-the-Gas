﻿using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManagerNo : MonoBehaviour {

	public static int score;

	static GameObject Car;

	static Text text;

	// Use this for initialization
	void Start () {
		text = GameObject.Find("Scoretext").GetComponent <Text> ();
		score = 100;
		//text.gameObject.SetActive (false);
		Time.timeScale = 1;

	}

	// Update is called once per frame
	void Update () {
		text.text = "Score: " + score;

		if (score <= 0) {
			score = 0;
			WakeUp ();
		} 			
	}

	void OnCollisionEnter (Collision col) {
		if (col.gameObject.tag == "finish") {
			WakeUp ();
		}
	}

	public static void WakeUp() {
		text.gameObject.SetActive (true);
		Time.timeScale = 0;
	}
}