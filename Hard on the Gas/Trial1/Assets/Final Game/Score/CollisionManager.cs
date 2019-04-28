using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour {

	public int colValue = 5;
	public int terValue = 3;
	public int flipValue = 30;

	void Start () {
		
	}
	
	void OnCollisionEnter (Collision col) {
		if (col.gameObject.tag == "obstacle") {
			ScoreManager.score -= colValue;
		}
		if (col.gameObject.tag == "terrain") {
			ScoreManager.score -= terValue;
		}
		if (transform.up.y < 0f) {
			ScoreManager.score -= flipValue;
		}
		if(Mathf.Abs(Vector3.Dot(transform.up, Vector3.down)) < 0.8f)
		{
			ScoreManager.score -= flipValue;
		}

		if(Mathf.Abs(Vector3.Dot(transform.right, Vector3.down)) > 0.4f)
		{
			ScoreManager.score -= flipValue;
		}
	}
}
