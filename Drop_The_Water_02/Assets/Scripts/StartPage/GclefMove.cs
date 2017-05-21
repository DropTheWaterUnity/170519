using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GclefMove : MonoBehaviour {

	float delta = 0.005f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		// Gclef Move y+=delta per frame
		float newYPosition = transform.position.y + delta;
		transform.position = new Vector3(0, newYPosition, 0);

		// Round trip
		if (transform.position.y <= -1.2){
			delta = 0.005f;
		} 
		else if (transform.position.y >= -1.0){
			delta = -0.005f;
		}

	}
}
