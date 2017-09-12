using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

	int score;
	// Use this for initialization
	void Start () {
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		print("Score <" + score + ">");
	}

	void OnControllerColliderHit(ControllerColliderHit hit) {
		// print("Collided with " + hit.gameObject.name);
		if (hit.gameObject.tag == "coin") {
			Destroy(hit.gameObject);
			score++;
		}
	}
}
