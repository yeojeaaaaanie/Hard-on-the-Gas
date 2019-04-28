using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public static int score;

	static GameObject Car;

	//GameObject WheelCollider;
	//GameObject WheelHubRearRight;
	//GameObject WheelHubFrontLeft;
	//GameObject WheelHubRearLeft;

	static Text text;

	// Use this for initialization
	void Start () {
		text = GetComponent <Text> ();
		score = 100;
		text.gameObject.SetActive (false);
		Time.timeScale = 1;
		//		Invoke ("WakeUp", 2);
	}

	// Update is called once per frame
	void Update () {
		text.text = "Score: " + score;

		if (score <= 0) {
			score = 0;
			WakeUp ();
		}

		//if (transform.up.y < 0f)
		//if(transform.rotation.eulerAngles.z == 40) 

		if(Mathf.Abs(Vector3.Dot(transform.up, Vector3.down)) < 0.8f)
		{
			// Car is primarily neither up nor down, within 1/8 of a 90 degree rotation

			score = 30;
			WakeUp ();

			// Therefore, check whether it's on either side. Otherwise, it's on front/back

		}

		if(Mathf.Abs(Vector3.Dot(transform.right, Vector3.down)) > 0.4f)
		{
			// Car is within 1/8 of a 90 degree rotation of either side

			score = 20;
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
		//WheelCollider.brakeTorque = 0;
		//WheelHubRearRight.motorTorque = 0;
		//WheelHubFrontLeft.motorTorque = 0;
		//WheelHubRearLeft.motorTorque = 0;
		}
}